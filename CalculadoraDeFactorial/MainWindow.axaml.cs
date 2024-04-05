using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CalculadoraDeFactorial;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Start_OnClick(object? sender, RoutedEventArgs e)
    {
        var secondWindow = new numbers();
        secondWindow.Show();
    }
}