using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShiYing.Utility
{
    /**
     * Simple command that executes with generic parameter.
     */
    public class SimpleCommand<T> : CommandBase
    {
        public Predicate<T> CanExecuteDelegate { get; set; }
        public Action<T> ExecuteDelegate { get; set; }

        protected override bool DoCanExecute(object parameter)
        {
            return true;
        }

        protected override void DoExecute(object parameter) => ExecuteDelegate?.Invoke((T)parameter);
    }
}
