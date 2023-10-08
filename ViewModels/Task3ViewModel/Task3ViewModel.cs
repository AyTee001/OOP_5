using OOP_5.Commands;
using OOP_5.Models;
using OOP_5.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using OOP_5.ViewModels.Abstract;

namespace OOP_5.ViewModels
{
    public partial class Task3ViewModel : ViewModelBase
    {
        private double? _num;

        private ICollection<MultiplicationGridItem>? _tableData;

        public ICommand CreateTable { get; }

        public string? Number
        {
            get => _num.HasValue ? _num.Value.ToString() : "";
            set
            {
                if (!double.TryParse(value, out double val))
                {
                    _num = null;
                }
                else
                {
                    _num = val;
                }
                OnPropertyChanged(nameof(Number));
            }
        }
        public ICollection<MultiplicationGridItem>? TableData
        {
            get => _tableData;
            set
            {
                _tableData = value;
                OnPropertyChanged(nameof(TableData));
            }
        }

        public Task3ViewModel() 
        {
            CreateTable = new RelayCommand((param) => GenerateTable());
        }

        private void GenerateTable()
        {
            if(_num is null)
            {
                return;
            }
            try
            {
                TableData = Task3Model.GenerateNultiplicationTableData((double)_num);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
