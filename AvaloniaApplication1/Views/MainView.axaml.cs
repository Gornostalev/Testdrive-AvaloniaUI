using Avalonia.Controls;
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
        if(double.TryParse(Celcius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Forengeits.Text = F.ToString("0.0");
        }
        else
        {
            Celcius.Text = "0";
            Forengeits.Text = "0";
        }
    }
}
