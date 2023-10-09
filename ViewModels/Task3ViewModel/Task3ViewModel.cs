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
        private bool _hasUserInteractedNumber = false;

        private string _num = "";

        private bool CanExecute = false;


        private ICollection<MultiplicationGridItem>? _tableData;

        public ICommand CreateTable { get; }

        public string Number
        {
            get => _num;
            set
            {
                _num = value;
                _hasUserInteractedNumber = true;
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
            CreateTable = new RelayCommand(
                    executeAction: (param) => GenerateTable(),
                    canExecuteFunc: (param) => CanExecute
                );
        }

        private void GenerateTable()
        {
            if(_num is null)
            {
                return;
            }
            try
            {
                TableData = Task3Model.GenerateNultiplicationTableData(double.Parse(_num));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
