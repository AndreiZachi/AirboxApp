using AirboxApp.Enums;
using AirboxApp.Manager;
using AirboxApp.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.ViewModels
{
    public partial class PresenterViewModel : BaseViewModel
    {

        #region Properties
        [ObservableProperty]
        public ObservableCollection<ImageSource> cars;
        [ObservableProperty]
        public ObservableCollection<ImageSource> helicopters;
        [ObservableProperty]
        public ObservableCollection<ImageSource> boats;
        [ObservableProperty]
        public ObservableCollection<ImageSource> selectedSet;
        #endregion

        #region Constructor
        public PresenterViewModel()
        {
            Title = "Image Presenter";
            PopulateImageSets();
        }
        #endregion

        #region Methods
        private void PopulateImageSets()
        {
            ImageManager imageManager = new ImageManager();

            Boats = imageManager.GetBoats();
            Cars = imageManager.GetCars();
            Helicopters = imageManager.GetHelicopters();
        }
        #endregion

        #region Commands
        public Command ChangeImageSet => new Command((sender) =>
        {
            var type = sender is null ? ImageSetType.CarType : (ImageSetType)sender;

            switch (type)
            {
                case ImageSetType.CarType:
                    SelectedSet = Cars;
                    break;
                case ImageSetType.BoatType:
                    SelectedSet = Boats;
                    break;
                case ImageSetType.HelicopterType:
                    SelectedSet = Helicopters;
                    break;
                default:
                    throw new NotImplementedException();
            }

            if (SelectedSet == null)
            {
                SelectedSet = new ObservableCollection<ImageSource>();
            }
        });

        #endregion
    }
}
