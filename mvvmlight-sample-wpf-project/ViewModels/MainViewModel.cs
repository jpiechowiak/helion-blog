using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows.Input;

namespace MvvmLightSampleWPFProject.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Guid data;

        public MainViewModel()
        {
            this.LoadDataCommand = new RelayCommand(() =>
            {
                this.Data = Guid.NewGuid();
            });
        }

        public ICommand LoadDataCommand { get; private set; }

        public Guid Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
                this.RaisePropertyChanged("Data");
            }
        }
    }
}
