using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tools.MVVM.ViewModels
{
    // ViewModelBase => Met en place la méthode pour notifier la vue d'un changement
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            RaiseAllCanExecuteChanged();
        }

        protected virtual void RaiseAllCanExecuteChanged() { }
    }
    public abstract class ViewModelBase<TModel> : ViewModelBase
    {
        private readonly TModel _Entity;

        protected TModel Entity
        {
            get { return _Entity; }
        }

        public ViewModelBase(TModel model)
        {
            if (model is null) throw new ArgumentNullException();

            _Entity = model;
        }
    }
}
