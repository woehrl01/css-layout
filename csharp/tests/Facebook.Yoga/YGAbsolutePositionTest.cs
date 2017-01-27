/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

 // @Generated by gentest/gentest.rb from gentest/fixtures/YGAbsolutePositionTest.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGAbsolutePositionTest
    {
        [Test]
        public void Test_absolute_layout_width_height_start_top()
        {
            YogaNode root = new YogaNode();
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Start = 10;
            root_child0.Top = 10;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_width_height_end_bottom()
        {
            YogaNode root = new YogaNode();
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.End = 10;
            root_child0.Bottom = 10;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_start_top_end_bottom()
        {
            YogaNode root = new YogaNode();
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Start = 10;
            root_child0.Top = 10;
            root_child0.End = 10;
            root_child0.Bottom = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_width_height_start_top_end_bottom()
        {
            YogaNode root = new YogaNode();
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Start = 10;
            root_child0.Top = 10;
            root_child0.End = 10;
            root_child0.Bottom = 10;
            root_child0.Width = 10;
            root_child0.Height = 10;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_do_not_clamp_height_of_absolute_node_to_height_of_its_overflow_hidden_parent()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.Overflow = YogaOverflow.Hidden;
            root.Width = 50;
            root.Height = 50;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Start = 0;
            root_child0.Top = 0;
            root.Insert(0, root_child0);

            YogaNode root_child0_child0 = new YogaNode();
            root_child0_child0.Width = 100;
            root_child0_child0.Height = 100;
            root_child0.Insert(0, root_child0_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(50f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(50f, root.LayoutHeight);

            Assert.AreEqual(-50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_within_border()
        {
            YogaNode root = new YogaNode();
            root.MarginLeft = 10;
            root.MarginTop = 10;
            root.MarginRight = 10;
            root.MarginBottom = 10;
            root.PaddingLeft = 10;
            root.PaddingTop = 10;
            root.PaddingRight = 10;
            root.PaddingBottom = 10;
            root.BorderLeftWidth = 10;
            root.BorderTopWidth = 10;
            root.BorderRightWidth = 10;
            root.BorderBottomWidth = 10;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Left = 0;
            root_child0.Top = 0;
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.PositionType = YogaPositionType.Absolute;
            root_child1.Right = 0;
            root_child1.Bottom = 0;
            root_child1.Width = 50;
            root_child1.Height = 50;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(10f, root.LayoutX);
            Assert.AreEqual(10f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(10f, root.LayoutX);
            Assert.AreEqual(10f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center()
        {
            YogaNode root = new YogaNode();
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_flex_end()
        {
            YogaNode root = new YogaNode();
            root.JustifyContent = YogaJustify.FlexEnd;
            root.AlignItems = YogaAlign.FlexEnd;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(60f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(60f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_justify_content_center()
        {
            YogaNode root = new YogaNode();
            root.JustifyContent = YogaJustify.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_center()
        {
            YogaNode root = new YogaNode();
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_center_on_child_only()
        {
            YogaNode root = new YogaNode();
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.AlignSelf = YogaAlign.Center;
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center_and_top_position()
        {
            YogaNode root = new YogaNode();
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Top = 10;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center_and_bottom_position()
        {
            YogaNode root = new YogaNode();
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Bottom = 10;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(50f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(25f, root_child0.LayoutX);
            Assert.AreEqual(50f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center_and_left_position()
        {
            YogaNode root = new YogaNode();
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Left = 5;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(5f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(5f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_align_items_and_justify_content_center_and_right_position()
        {
            YogaNode root = new YogaNode();
            root.JustifyContent = YogaJustify.Center;
            root.AlignItems = YogaAlign.Center;
            root.FlexGrow = 1;
            root.Width = 110;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.Right = 5;
            root_child0.Width = 60;
            root_child0.Height = 40;
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(110f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(30f, root_child0.LayoutY);
            Assert.AreEqual(60f, root_child0.LayoutWidth);
            Assert.AreEqual(40f, root_child0.LayoutHeight);
        }

    }
}
