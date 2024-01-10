using System.Windows;
using MyCalculator.MVVM;

namespace MyCalculator.ViewModels;

internal class CalculatorViewModel : ViewModelBase
{
    private string _output;
    private string _operator;
    private string _previousInput;

    public RelayCommand AddNumber => new RelayCommand(execute => NumberButtonClick(execute));
    public RelayCommand ResetNumber => new RelayCommand(execute => ResetButtonClick());
    public RelayCommand Operation => new RelayCommand(execute => OperatorButtonClick(execute));
    public RelayCommand Equal => new RelayCommand(execute => EqualButtonClick());

    public string Output
    {
        get { return _output; }
        set
        {
            if (_output != null)
            {
                _output = value;
                OnPropertyChanged();
            }
        }
    }

    public CalculatorViewModel()
    {
        _output = "";
        _operator = "";
        _previousInput = "";
    }

    public void ResetButtonClick()
    {
        Output = "";
        _operator = "";
        _previousInput = "";
    }


    private void OperatorButtonClick(object op)
    {
        if (op == null) return;

        if (Output == "")
        {
            MessageBox.Show("처음 숫자를 넣어주세요");
            return;
        }

        _operator = op.ToString();
        _previousInput = Output;
        Output = "";
    }

    private void EqualButtonClick()
    {
        if (_previousInput != "" && Output != "" && _operator != "")
        {
            var result = _operator switch
            {
                "+" => double.Parse(_previousInput) + double.Parse(_output),
                "-" => double.Parse(_previousInput) - double.Parse(_output),
                "/" => double.Parse(_previousInput) / double.Parse(_output),
                _ => double.Parse(_previousInput) * double.Parse(_output),
            };
            Output = result.ToString();
        }
        else
        {
            MessageBox.Show("다시 시도해 주세요!");
            ResetButtonClick();
        }
    }

    private void NumberButtonClick(object execute)
    {
        string name = execute.ToString();

        switch (name)
        {
            case "OneButton":
                Output += 1;
                break;
            case "TwoButton":
                Output += 2;
                break;
            case "ThreeButton":
                Output += 3;
                break;
            case "FourButton":
                Output += 4;
                break;
            case "FiveButton":
                Output += 5;
                break;
            case "SixButton":
                Output += 6;
                break;
            case "SevenButton":
                Output += 7;
                break;
            case "EightButton":
                Output += 8;
                break;
            case "NineButton":
                Output += 9;
                break;
            case "ZeroButton":
                Output += 0;
                break;
        }
    }
}

