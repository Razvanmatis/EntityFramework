using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EntityFramework.Helper
{
    public class DelegateCommand : ICommand
    {
        private Action<object> action;
        private Func<object, bool> canExecute;

        public DelegateCommand(Action<object> action, Func<object, bool> canExecute)
        {
            this.action = action;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            action.Invoke(parameter);
        }
    }
}
