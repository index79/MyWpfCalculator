using System.Windows;
using System.Windows.Controls;

namespace MyCalculator
{
    public partial class MainWindow : Window
    {
        string output = "";
        string operation = "";
        string previousInput = "";

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void ClearTextBlock()
        {
            output = "";
            OutputTextBlock.Text = output;
        }

        public void ResetCalculator()
        {
            ClearTextBlock();
            operation = previousInput = "";

        }

        public bool ValidateOperation()
        {
            if (output == "")
            {
                MessageBox.Show("처음 숫자를 넣어주세요");
                return false;
            }
            return true;
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ResetCalculator();
        }

        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateOperation()) return;
 
            operation = "/";
            previousInput = output;
            ClearTextBlock();
        }

        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateOperation()) return;

            operation = "*";
            previousInput = output;
            ClearTextBlock();
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateOperation()) return;

            operation = "-";
            ClearTextBlock();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateOperation()) return;

            operation = "+";
            previousInput = output;
            ClearTextBlock();
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if(previousInput != "" && output != "" && operation != "")
            {
                var result = operation switch
                {
                    "+" => double.Parse(previousInput) + double.Parse(output),
                    "-" => double.Parse(previousInput) - double.Parse(output),
                    "/" => double.Parse(previousInput) / double.Parse(output),
                    _ => double.Parse(previousInput) * double.Parse(output),
                };
                OutputTextBlock.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("다시 시도해 주세요!");
                ResetCalculator();
            }
        }

        private void NumButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;
            switch(name)
            {
                case "OneButton":
                    output += 1;
                    OutputTextBlock.Text = output;
                    break;
                case "TwoButton":
                    output += 2;
                    OutputTextBlock.Text = output;
                    break;
                case "ThreeButton":
                    output += 3;
                    OutputTextBlock.Text = output;
                    break;
                case "FourButton":
                    output += 4;
                    OutputTextBlock.Text = output;
                    break;
                case "FiveButton":
                    output += 5;
                    OutputTextBlock.Text = output;
                    break;
                case "SixButton":
                    output += 6;
                    OutputTextBlock.Text = output;
                    break;
                case "SevenButton":
                    output += 7;
                    OutputTextBlock.Text = output;
                    break;
                case "EightButton":
                    output += 8;
                    OutputTextBlock.Text = output;
                    break;
                case "NineButton":
                    output += 9;
                    OutputTextBlock.Text = output;
                    break;
                case "ZeroButton":
                    output += 0;
                    OutputTextBlock.Text = output;
                    break;
            }
        }
    }
}