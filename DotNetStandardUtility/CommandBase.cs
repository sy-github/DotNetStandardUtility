using System;
using System.Windows.Input;

namespace ShiYing.Utility
{
    /**
     * Base command class providing pluginable delegates for ICommand methods.
     */
    public abstract class CommandBase : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => DoCanExecute(parameter);

        public void Execute(object parameter) => DoExecute(parameter);

        protected abstract bool DoCanExecute(object parameter);
        protected abstract void DoExecute(object parameter);
    }
}
