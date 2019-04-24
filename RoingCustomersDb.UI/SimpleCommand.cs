using System;
using System.Windows.Input;

namespace RoingCustomersDb.UI
{
    class SimpleCommand : ICommand
    {
        protected readonly Func<bool> _canExecute;
        protected readonly Action _execute;

        public event EventHandler CanExecuteChanged;

        public SimpleCommand(Action execute)
            : this(execute, () => true) { }

        public SimpleCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute ?? throw new ArgumentNullException(nameof(canExecute));
        }

        public bool CanExecute(object parameter) => _canExecute();
        public void Execute(object parameter) => _execute();

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
}
