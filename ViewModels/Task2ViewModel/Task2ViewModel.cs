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

        private int? _age;

        private string? _category;

        public ICommand FindAgeCategory { get; }

        public List<string> OperatorOptions { get; } = Enum.GetNames(typeof(AgeCategories)).ToList();
        public string? Age
        {
            get => _age.HasValue ? _age.Value.ToString() : "";
            set
            {
                if (!int.TryParse(value, out int val))
                {
                    _age = null;
                }
                else
                {
                    _age = val;
                }
                _hasUserInteractedAge = true;
                OnPropertyChanged(nameof(Age));
            }
        }
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
            FindAgeCategory = new RelayCommand((param) => CalculateAgeCategory());
        }
        private void CalculateAgeCategory()
        {
            if (_age is null)
            {
                return;
            }
            try
            {
                var ageCat = Task2Model.DefineAge((int)_age);
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
