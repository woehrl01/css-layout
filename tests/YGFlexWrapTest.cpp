/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

 // @Generated by gentest/gentest.rb from gentest/fixtures/YGFlexWrapTest.html

#include <yoga/Yoga.h>
#include <gtest/gtest.h>

TEST(YogaTest, wrap_column) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetFlexWrap(root, YGWrapWrap);
  YGNodeStyleSetHeightWithUnit(root, YGPx(100));

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child0, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child0, YGPx(30));
  YGNodeInsertChild(root, root_child0, 0);

  const YGNodeRef root_child1 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child1, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child1, YGPx(30));
  YGNodeInsertChild(root, root_child1, 1);

  const YGNodeRef root_child2 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child2, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child2, YGPx(30));
  YGNodeInsertChild(root, root_child2, 2);

  const YGNodeRef root_child3 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child3, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child3, YGPx(30));
  YGNodeInsertChild(root, root_child3, 3);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child1));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child2));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetTop(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child2));

  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetLeft(root_child3));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child3));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child1));

  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetLeft(root_child2));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetTop(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child2));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child3));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child3));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, wrap_row) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetFlexDirection(root, YGFlexDirectionRow);
  YGNodeStyleSetFlexWrap(root, YGWrapWrap);
  YGNodeStyleSetWidthWithUnit(root, YGPx(100));

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child0, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child0, YGPx(30));
  YGNodeInsertChild(root, root_child0, 0);

  const YGNodeRef root_child1 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child1, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child1, YGPx(30));
  YGNodeInsertChild(root, root_child1, 1);

  const YGNodeRef root_child2 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child2, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child2, YGPx(30));
  YGNodeInsertChild(root, root_child2, 2);

  const YGNodeRef root_child3 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child3, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child3, YGPx(30));
  YGNodeInsertChild(root, root_child3, 3);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child1));

  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetLeft(root_child2));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child2));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child3));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(70, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child1));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child2));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child2));

  ASSERT_FLOAT_EQ(70, YGNodeLayoutGetLeft(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child3));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, wrap_row_align_items_flex_end) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetFlexDirection(root, YGFlexDirectionRow);
  YGNodeStyleSetAlignItems(root, YGAlignFlexEnd);
  YGNodeStyleSetFlexWrap(root, YGWrapWrap);
  YGNodeStyleSetWidthWithUnit(root, YGPx(100));

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child0, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child0, YGPx(10));
  YGNodeInsertChild(root, root_child0, 0);

  const YGNodeRef root_child1 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child1, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child1, YGPx(20));
  YGNodeInsertChild(root, root_child1, 1);

  const YGNodeRef root_child2 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child2, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child2, YGPx(30));
  YGNodeInsertChild(root, root_child2, 2);

  const YGNodeRef root_child3 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child3, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child3, YGPx(30));
  YGNodeInsertChild(root, root_child3, 3);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(20, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(20, YGNodeLayoutGetHeight(root_child1));

  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetLeft(root_child2));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child2));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child3));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(70, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(20, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(20, YGNodeLayoutGetHeight(root_child1));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child2));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child2));

  ASSERT_FLOAT_EQ(70, YGNodeLayoutGetLeft(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child3));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, wrap_row_align_items_center) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetFlexDirection(root, YGFlexDirectionRow);
  YGNodeStyleSetAlignItems(root, YGAlignCenter);
  YGNodeStyleSetFlexWrap(root, YGWrapWrap);
  YGNodeStyleSetWidthWithUnit(root, YGPx(100));

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child0, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child0, YGPx(10));
  YGNodeInsertChild(root, root_child0, 0);

  const YGNodeRef root_child1 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child1, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child1, YGPx(20));
  YGNodeInsertChild(root, root_child1, 1);

  const YGNodeRef root_child2 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child2, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child2, YGPx(30));
  YGNodeInsertChild(root, root_child2, 2);

  const YGNodeRef root_child3 = YGNodeNew();
  YGNodeStyleSetWidthWithUnit(root_child3, YGPx(30));
  YGNodeStyleSetHeightWithUnit(root_child3, YGPx(30));
  YGNodeInsertChild(root, root_child3, 3);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(5, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(20, YGNodeLayoutGetHeight(root_child1));

  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetLeft(root_child2));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child2));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child3));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(70, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(5, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(20, YGNodeLayoutGetHeight(root_child1));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child2));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child2));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child2));

  ASSERT_FLOAT_EQ(70, YGNodeLayoutGetLeft(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetWidth(root_child3));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetHeight(root_child3));

  YGNodeFreeRecursive(root);
}
