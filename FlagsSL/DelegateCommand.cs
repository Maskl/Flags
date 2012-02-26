using System;
using System.Windows.Input;

namespace NavigationSample
{
    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> _command;

        public DelegateCommand(Action<T> command)
        {
            _command = command;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _command((T)parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}