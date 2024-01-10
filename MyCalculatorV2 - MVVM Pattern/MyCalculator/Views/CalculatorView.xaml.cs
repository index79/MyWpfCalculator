using MyCalculator.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace MyCalculator;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        CalculatorViewModel vm = new CalculatorViewModel();
        DataContext = vm;
    }
}
