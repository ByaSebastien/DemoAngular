using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVVM_01.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Field
        private int _Counter;
        private string _Message;
        private string _Message2;
        private string _MessageFinish;

        #endregion

        #region Props
        public int Counter
        {
            get { return _Counter; }
            set
            {
                _Counter = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(Counter)));
            }
        }
        public string Message
        {
            get { return _Message; }
            set { _Message = value.ToUpper(); }
        }
        public string Message2
        {
            get { return _Message2; }
            set { _Message2 = value.ToUpper(); }
        }
        public string MessageFinish
        {
            get { return _MessageFinish; }
            set
            {
                _MessageFinish = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MessageFinish)));
            }
        }
        #endregion

        #region Ctor
        public MainViewModel()
        {
            Counter = 0;
            _Message = "";
            _Message2 = "";
            Task t = new Task(UpdateCount);
            t.Start();
        }
        #endregion

        #region Methodes
        private void UpdateCount()
        {
            while (Counter < 100)
            {
                System.Threading.Thread.Sleep(50);
                Counter++;
            }
            MessageFinish = "Finito!!!";
        }
        #endregion
    }
}
