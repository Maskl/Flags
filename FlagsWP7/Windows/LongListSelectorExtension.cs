﻿#region License
// Copyright (c) 2011 Claus Jørgensen <10229@iha.dk>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE
#endregion
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

namespace Flags
{
    public static class LongListSelectorExtension
    {
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached("Command",
                typeof(ICommand), typeof(LongListSelectorExtension),
                new PropertyMetadata(null, OnCommandChanged));

        public static ICommand GetCommand(LongListSelector selector)
        {
            return (ICommand)selector.GetValue(CommandProperty);
        }

        public static void SetCommand(LongListSelector selector, ICommand value)
        {
            selector.SetValue(CommandProperty, value);
        }

        private static void OnCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var selector = d as LongListSelector;
            if (selector == null)
            {
                throw new ArgumentException(
                    "You must set the Command attached property on an element that derives from LongListSelector.");
            }

            var oldCommand = e.OldValue as ICommand;
            if (oldCommand != null)
            {
                selector.SelectionChanged -= OnSelectionChanged;
            }

            var newCommand = e.NewValue as ICommand;
            if (newCommand != null)
            {
                selector.SelectionChanged += OnSelectionChanged;
            }
        }

        private static void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selector = sender as LongListSelector;
            var command = GetCommand(selector);

            if (command != null)
            {
                command.Execute(selector.SelectedItem);
            }
        }
    }
}