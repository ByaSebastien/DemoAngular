using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVVM_02.Tools
{
    public class RelayCommand : IRelayCommand
    {
        public event EventHandler? CanExecuteChanged;
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        private readonly Action _Execute;
        private readonly Func<bool> _CanExecute;

        public void Execute(object? parameter)
        {
            _Execute();
        }

        public bool CanExecute(object? parameter)
        {
            return _CanExecute?.Invoke() ?? true;
        }

        public RelayCommand(Action execute,Func<bool> canExecute = null)
        {
            if (execute is null) throw new ArgumentNullException();

            _Execute = execute;
            _CanExecute = canExecute;
        }
    }
}
