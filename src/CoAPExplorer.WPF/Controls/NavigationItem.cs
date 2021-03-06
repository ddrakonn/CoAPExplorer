﻿using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CoAPExplorer.WPF.Controls
{
    public class NavigationItem : HeaderedContentControl
    {
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(
            nameof(Icon), typeof(object), typeof(NavigationItem));

        public object Icon { get => GetValue(IconProperty); set => SetValue(IconProperty, value); }
    }
}
