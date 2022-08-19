using Demo_MVVM_Modele_03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.MVVM.Commands;
using Tools.MVVM.ViewModels;
using static Demo_MVVM_Modele_03.FakeDbContext;

namespace Demo_MVVM_Modele_03.ViewModels
{
    public class CarViewModel : ViewModelBase<Car>
    {
        public static event Action<CarViewModel>? OnCarDeleted;

        public string? Brand
        {
            get { return Entity.Brand; }
        }

        public string? Model
        {
            get { return Entity.Model; }
        }

        public ConditionCar Condition
        {
            get { return Entity.Condition; }
        }

        public int Kilometers
        {
            get { return Entity.Kilometers; }
            set
            {
                Entity.Kilometers = value;
                RaisePropertyChanged();
            }
        }

        public bool IsFunctional
        {
            get { return Entity.IsFunctional; }
            set
            {
                Entity.IsFunctional = value;
                RaisePropertyChanged();

            }
        }

        public double Price
        {
            get { return Entity.Price; }
            set
            {
                Entity.Price = value;
                RaisePropertyChanged();

            }

        }

        public bool HasStock
        {
            get { return Entity.HasStock; }
            set
            {
                Entity.HasStock = value;
                RaisePropertyChanged();
            }
        }

        private IRelayCommand? _DeleteCommand;
        private IRelayCommand? _SoldCommand;

        public IRelayCommand DeleteCommand
        {
            get { return _DeleteCommand ?? (_DeleteCommand = new RelayCommand(Delete)); }
        }

        public IRelayCommand SoldCommand
        {
            get { return _SoldCommand ?? (_SoldCommand = new RelayCommand(Sold, CanSold)); }
        }

        public CarViewModel(Car car) : base(car) { }

        protected override void RaiseAllCanExecuteChanged()
        {
            SoldCommand.RaiseCanExecuteChanged();
        }

        private void Delete()
        {
            CarService carService = new CarService();

            carService.Delete(Entity.Id);

            OnCarDeleted?.Invoke(this);
        }

        private void Sold()
        {
            Entity.HasStock = false;

            CarService carService = new CarService();

            carService.Update(Entity);
        }

        private bool CanSold()
        {
            return HasStock;
        }
    }
}
