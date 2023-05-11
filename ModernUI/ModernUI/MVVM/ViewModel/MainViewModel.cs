using ModernUI.Core;
using ModernUI.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernUI.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand DiscoveryViewCommand { get; set; }


        public HomeViewModel HomeVM { get; set; }

        public DiscoveryViewModel DiscoveryVM { get; set; }


        private object _currentView;

        public object CurrentVIew
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
 
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();

            CurrentVIew = HomeVM;

            HomeViewCommand = new RelayCommand(o => {
                CurrentVIew = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentVIew = DiscoveryVM;
            });
        }
    }
}
