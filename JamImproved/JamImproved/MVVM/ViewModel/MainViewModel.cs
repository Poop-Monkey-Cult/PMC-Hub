using JamImproved.Core;
using System;

namespace JamImproved.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand  HomeviewCommand { get; set; }

        public RelayCommand BlacklistviewCommand { get; set; }

        public HomeViewModel HomeVm { get; set; }

        public BlacklistViewModel BlacklistVm { get; set; }

        private object _currentView;

        public object CurrentView
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
            HomeVm = new HomeViewModel();
            BlacklistVm = new BlacklistViewModel();
            CurrentView = HomeVm;

            HomeviewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });

            BlacklistviewCommand = new RelayCommand(o =>
            {
                CurrentView = BlacklistVm;
            });
        }
    }
}