﻿using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace AvaloniaApplication1.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Debug.WriteLine("Click!");
    }
}
