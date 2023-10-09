using OOP_5.Enums;
using OOP_5.ViewModels.Abstract;
using System.Collections.Generic;
using System;
using System.Linq;
using OOP_5.Commands;
using OOP_5.Models;
using System.Windows;
using System.Windows.Input;

namespace OOP_5.ViewModels
{
    public partial class Task2ViewModel : ViewModelBase
    {
        private bool _hasUserInteractedAge = false;

        private string _age = "";

        private string? _category;

        public ICommand FindAgeCategory { get; }

        public List<string> OperatorOptions { get; } = Enum.GetNames(typeof(AgeCategories)).ToList();
        public string Age
        {
            get => _age;
            set
            {
                _age = value;
                _hasUserInteractedAge = true;
                OnPropertyChanged(nameof(Age));
            }
        }
        private bool CanExecute = false;

        public string? Category
        {
            get => _category;
            set
            {
                _category = value;
                OnPropertyChanged(nameof(Category));
            }
        }
        public Task2ViewModel()
        {
            FindAgeCategory = new RelayCommand(
                    executeAction: (param) => CalculateAgeCategory(),
                    canExecuteFunc: (param) => CanExecute
                );
        }
        private void CalculateAgeCategory()
        {
            try
            {
                var ageCat = Task2Model.DefineAge(int.Parse(_age));
                Category = Enum.GetName(typeof(AgeCategories), ageCat); ;
            }
            catch (Exception ex)
            {
                Category = "Could not find category";
                MessageBox.Show(ex.Message);
            }
        }
    }
}
