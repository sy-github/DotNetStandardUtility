using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShiYing
{
    public class SimpleCommand : ICommand
    {
        public Predicate<object> CanExecuteDelegate { get; set; }
        public Action ExecuteDelegate { get; set; }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            var canExecute = CanExecuteDelegate?.Invoke(parameter) ?? true;
            CanExecuteChanged?.Invoke(this, new EventArgs());
            return canExecute;
        }

        public void Execute(object parameter) => ExecuteDelegate?.Invoke();
    }

    public class SimpleCommand<T> : SimpleCommand
    {
        public new Predicate<T> CanExecuteDelegate { get; set; }
        public new Action<T> ExecuteDelegate { get; set; }

        public new event EventHandler CanExecuteChanged;

        public new bool CanExecute(object parameter)
        {
            var canExecute = CanExecuteDelegate?.Invoke((T)parameter) ?? true;
            CanExecuteChanged?.Invoke(this, new EventArgs());
            return canExecute;
        }

        public new void Execute(object parameter) => ExecuteDelegate?.Invoke((T)parameter);
    }
}
