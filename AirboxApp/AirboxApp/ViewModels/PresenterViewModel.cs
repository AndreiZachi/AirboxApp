using AirboxApp.Enums;
using AirboxApp.Manager;
using AirboxApp.Models;
using AirboxApp.Views;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.ViewModels
{
    public partial class PresenterViewModel : BaseViewModel
    {

        #region Properties
        /// <summary>
        /// Collection of car images.
        /// </summary>
        [ObservableProperty]
        public ObservableCollection<VehicleImage> cars;

        /// <summary>
        /// Collection of helicopter images.
        /// </summary>
        [ObservableProperty]
        public ObservableCollection<VehicleImage> helicopters;

        /// <summary>
        /// Collection of boat images.
        /// </summary>
        [ObservableProperty]
        public ObservableCollection<VehicleImage> boats;

        /// <summary>
        /// The currently selected set of images, which can be cars, boats, or helicopters.
        /// </summary>
        [ObservableProperty]
        public ObservableCollection<VehicleImage> selectedSet;
        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PresenterViewModel"/> class.
        /// Populates the image sets with default values.
        /// </summary>
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
            // Fetching images for boats, cars, and helicopters from ImageManager
            Boats = imageManager.GetBoats();
            Cars = imageManager.GetCars();
            Helicopters = imageManager.GetHelicopters();
        }
        #endregion

        #region Commands

        /// <summary>
        /// Command to change the currently selected set of images (e.g., cars, boats, or helicopters).
        /// </summary>
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
            // Ensure SelectedSet is not null
            if (SelectedSet == null)
            {
                SelectedSet = new ObservableCollection<VehicleImage>();
            }
        });

        /// <summary>
        /// Command to display a selected image in full screen.
        /// </summary>
        public Command ShowImageFullScreen => new Command(async(sender) =>
        {
            // Find the image corresponding to the provided image ID.
            var image = SelectedSet.FirstOrDefault(w => w.Id == (Guid)sender);

            // Get the current page and ensure it's not null.
            Page page = Application.Current?.MainPage ?? throw new NullReferenceException();

            // Create and display the full-screen popup for the selected image.
            var pop = new FullScreenImage();
            var vm = pop.BindingContext as FullScreenImageViewModel;

            // Set the full-screen image to the selected image.
            vm.FullScreenImage = image?.Image;

            // Set up a back command to close the popup when back is pressed with fading animation
            vm.BackPressed = new Command(async () =>
            {
                Debug.Assert(pop.Content is not null);
                await pop.Content.FadeTo(0, 500, Easing.Linear);
                await pop.CloseAsync(); 
            });

            // Display the popup.
            await page.ShowPopupAsync(pop);
        });

        #endregion
    }
}
