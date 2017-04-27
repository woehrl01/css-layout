/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

#include "YGInterop.h"

static int unmanagedLogger(const YGConfigRef config, const YGNodeRef node, YGLogLevel level, const char *format, va_list args) {
  int result = 0;
  YGInteropLoggerFunc managedFunc = (YGInteropLoggerFunc)YGConfigGetContext(config);
  if (managedFunc) {
    char buffer[256];
    result = vsnprintf(buffer, sizeof(buffer), format, args);
    (*managedFunc)(node, level, buffer);
  }
  return result;
}

void YGInteropSetLogger(const YGConfigRef config, YGInteropLoggerFunc managedFunc) {
  YGConfigSetContext(config, managedFunc);
  YGSetLogger(config, &unmanagedLogger);
}
