using System.Diagnostics;
using Avalonia.Controls;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (double.TryParse(Celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fahrenheit.Text = F.ToString("0.00");
        }
        else
        {
            Fahrenheit.Text = "0";
            Celsius.Text = "0";
        }
    }
}
