using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.MVVM.ViewModels;
using static Demo_MVVM_Modele_03.FakeDbContext;

namespace Demo_MVVM_Modele_03.ViewModels
{
    public class MainViewModel : ViewModelCollectionBase<CarViewModel>
    {
        private CarService _CarService;

        public MainViewModel()
        {
            _CarService = new CarService();
            CarViewModel.OnCarDeleted += HandleCarDeleted;
        }

        protected override ObservableCollection<CarViewModel> LoadItems()
        {
            return new ObservableCollection<CarViewModel>(_CarService.GetAll().Select(c => new CarViewModel(c)));
        }

        private void HandleCarDeleted(CarViewModel carViewModel)
        {
            Items.Remove(carViewModel);
        }
    }
}
