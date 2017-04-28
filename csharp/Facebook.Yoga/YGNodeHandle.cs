/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

using System;
using System.Runtime.InteropServices;

namespace Facebook.Yoga
{
    internal class YGNodeHandle : SafeHandle
    {
        private GCHandle _managedNodeHandle;

        private YGNodeHandle() : base(IntPtr.Zero, true)
        {
        }

        public override bool IsInvalid
        {
            get
            {
                return this.handle == IntPtr.Zero;
            }
        }

        protected override bool ReleaseHandle()
        {
            ReleaseManaged();
            if (!IsInvalid)
            {
                Native.YGNodeFree(this.handle);
                GC.KeepAlive(this);
            }
            return true;
        }

        public void SetContext(YogaNode node)
        {
            if (!_managedNodeHandle.IsAllocated)
            {
#if ENABLE_IL2CPP
                // Weak causes 'GCHandle value belongs to a different domain' error
                _managedNodeHandle = GCHandle.Alloc(node);
#else
                _managedNodeHandle = GCHandle.Alloc(node, GCHandleType.Weak);
#endif
                var managedNodePtr = GCHandle.ToIntPtr(_managedNodeHandle);
                Native.YGNodeSetContext(this.handle, managedNodePtr);
            }
        }

        public void ReleaseManaged()
        {
            if (_managedNodeHandle.IsAllocated)
            {
                _managedNodeHandle.Free();
            }
        }

        public static YogaNode GetManaged(IntPtr unmanagedNodePtr)
        {
            if (unmanagedNodePtr != IntPtr.Zero)
            {
                var managedNodePtr = Native.YGNodeGetContext(unmanagedNodePtr);
                var node = GCHandle.FromIntPtr(managedNodePtr).Target as YogaNode;
                if (node == null)
                {
                    throw new InvalidOperationException("YogaNode is already deallocated");
                }
                return node;
            }
            return null;
        }
    }
}
