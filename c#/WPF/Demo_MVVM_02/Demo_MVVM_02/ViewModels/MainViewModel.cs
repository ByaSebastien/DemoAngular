using Demo_MVVM_02.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVVM_02.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private int _Number;

        public int Number
        {
            get { return _Number; }
            set
            {
                _Number = value;
                RaisePropertyChanged();
            }
        }

        public IRelayCommand CommandPlus { get; set; }
        public IRelayCommand CommandMinus { get; set; }
        public IRelayCommand CommandReset { get; set; }

        public MainViewModel()
        {
            _Number = 0;
            CommandPlus = new RelayCommand(IncrementNumber,IncrementCheck);
            CommandMinus = new RelayCommand(DecrementNumber, DecrementCheck);
            CommandReset = new RelayCommand(ResetNumber,CheckReset);
        }

        private void IncrementNumber()
        {
            Number++;
            CommandPlus.RaiseCanExecuteChanged();
            CommandMinus.RaiseCanExecuteChanged();
            CommandReset.RaiseCanExecuteChanged();
        }

        private bool IncrementCheck()
        {
            return Number < 10;
        }

        private void DecrementNumber()
        {
            Number--;
            CommandPlus.RaiseCanExecuteChanged();
            CommandMinus.RaiseCanExecuteChanged();
            CommandReset.RaiseCanExecuteChanged();
        }

        private bool DecrementCheck()
        {
            return Number > -10;
        }

        private void ResetNumber()
        {
            Number = 0;
            CommandPlus.RaiseCanExecuteChanged();
            CommandMinus.RaiseCanExecuteChanged();
            CommandReset.RaiseCanExecuteChanged();
        }

        private bool CheckReset()
        {
            return Number != 0;
        }
    }
}
