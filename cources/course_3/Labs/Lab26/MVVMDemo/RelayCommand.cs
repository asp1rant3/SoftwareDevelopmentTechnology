﻿using System.Windows.Input;
using System;

namespace MVVMDemo
{
    public class RelayCommand : ICommand  
    {  
        public RelayCommand(Action<object> execute): this(execute, null)  
        {  
        }  
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)  
        {  
            if (execute == null)  
                throw new ArgumentNullException("execute");  
            _execute = execute;  
            _canExecute = canExecute;  
        }  
        public bool CanExecute(object parameter)  
        {  
            return _canExecute == null ? true : _canExecute(parameter);  
        }  
        public event EventHandler CanExecuteChanged  
        {  
            add { CommandManager.RequerySuggested += value; }  
            remove { CommandManager.RequerySuggested -= value; }  
        }  
        public void Execute(object parameter)  
        {  
            _execute(parameter);  
        }  
        private readonly Action<object> _execute;  
        private readonly Predicate<object> _canExecute;  
    }  
}