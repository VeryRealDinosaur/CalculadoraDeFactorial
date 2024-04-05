using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CalculadoraDeFactorial;

public partial class numbers : Window
{
    public numbers()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        NumLabel = this.FindControl<Label>("NumLabel");
        num[0] = rnd.Next(0, 10);
        NumLabel.Content = num[0];
        FactorialLabel = this.FindControl<Label>("FactorialLabel");
        FactorialLabel.Content = factorial(num[0]);
        ErrorLabel = this.FindControl<Label>("ErrorLabel");
    }

    public int[] num = new int[10];
    Random rnd = new Random();

    int factorial(int valor)
    {
        if (valor == 0)
        {
            return 1;
        }
        else
        {
            int result = 1;
            for (int i = 1; i <= valor; i++)
            {
                result *= i;
            }
            return result;
        }
    }
    
    public int j = 0;
    private int count = 0;
    
    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        count++;
        if (count < 10)
        {
            j++;
            num[j] = rnd.Next(0, 10);
            NumLabel.Content = num[j];
            FactorialLabel.Content = factorial(num[j]);
        }
        else
        {
            ErrorLabel.Content = "Ya se han generado 10 valores.";
        }
    }
}