﻿using System;
using System.Windows.Input;

namespace OOP_5.Commands
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _executeAction;
        private readonly Func<object?, bool> _canExecuteFunc;

        public RelayCommand(Action<object?> executeAction, Func<object?, bool> canExecuteFunc)
        {
            _executeAction = executeAction;
            _canExecuteFunc = canExecuteFunc;
        }

        public bool CanExecute(object? parameter) => _canExecuteFunc(parameter);

        public void Execute(object? parameter) => _executeAction(parameter);

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }
    }
}
