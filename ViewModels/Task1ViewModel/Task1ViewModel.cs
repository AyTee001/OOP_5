using OOP_5.Commands;
using OOP_5.Enums;
using OOP_5.Models;
using OOP_5.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace OOP_5.ViewModels
{
    public partial class Task1ViewModel : ViewModelBase
    {
        public ICommand Calculate { get; }

        private double? _number1;

        private double? _number2;

        private ArithmeticOperators _arithmeticOperator;

        private string? _calculationResults;

        public List<string> OperatorOptions { get; } = Enum.GetNames(typeof(ArithmeticOperators)).ToList();
        public string? CalculationResults
        {
            get => _calculationResults;
            set
            {
                _calculationResults = value;
                OnPropertyChanged(nameof(CalculationResults));
            }
        }
        public string? Number1
        {
            get => _number1.ToString();
            set
            {
                if (!double.TryParse(value, out double val))
                {
                    _number1 = null;
                }
                else
                {
                    _number1 = val;
                }
                OnPropertyChanged(nameof(Number1));
            }
        }
        public string? Number2
        {
            get => _number2.ToString();
            set
            {
                if (!double.TryParse(value, out double val))
                {
                    _number2 = null;
                }
                else
                {
                    _number2 = val;
                }
                OnPropertyChanged(nameof(Number2));
            }
        }

        public string ArithmeticOperator
        {
            get => _arithmeticOperator.ToString();
            set
            {
                if (Enum.TryParse(value, out ArithmeticOperators result))
                {
                    _arithmeticOperator = result;
                    OnPropertyChanged(nameof(ArithmeticOperator));
                }
            }
        }

        public Task1ViewModel()
        {
            Calculate = new RelayCommand((param) => ActionWithTwoNums());
        }


        private void ActionWithTwoNums()
        {
            if (_number1 is null || _number2 is null)
            {
                return;
            }
            double result;
            try
            {
                result = Task1Model.ActionWithToNums((double)_number1, (double)_number2, _arithmeticOperator);
                CalculationResults = result.ToString();
            }
            catch (Exception ex)
            {
                CalculationResults = "Fatal error";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
