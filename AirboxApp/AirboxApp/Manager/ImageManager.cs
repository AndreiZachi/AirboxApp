using AirboxApp.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;


namespace AirboxApp.Manager
{
    /// <summary>
    /// The ImageManager class is responsible for retrieving and managing collections of vehicle images 
    /// (boats, cars, helicopters) from embedded resources.
    /// </summary>
    public class ImageManager
    {
        #region Methods

        /// <summary>
        /// Retrieves a collection of boat images from embedded resources.
        /// </summary>
        /// <returns>
        /// An <see cref="ObservableCollection{VehicleImage}"/> containing boat images.
        /// </returns>
        public ObservableCollection<VehicleImage> GetBoats()
        {
            ObservableCollection<VehicleImage> vehicleSet = new ObservableCollection<VehicleImage>();

            // Get all resource names from the current assembly
            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            int i = 0;

            // Iterate through the resources to find those that contain boat images
            foreach (var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Boats"))
                {
                    // Add boat image to the collection with a unique ID
                    vehicleSet.Add(new VehicleImage { Image = ImageSource.FromResource(resource), Name = $"Boat{i}", Id = Guid.NewGuid() });

                    // Limit the collection to 9 items
                    if (i == 8)
                    {
                        return vehicleSet;
                    }
                    i++;
                }
            }
            return vehicleSet;
        }

        /// <summary>
        /// Retrieves a collection of car images from embedded resources.
        /// </summary>
        /// <returns>
        /// An <see cref="ObservableCollection{VehicleImage}"/> containing car images.
        /// </returns>
        public ObservableCollection<VehicleImage> GetCars()
        {
            ObservableCollection<VehicleImage> vehicleSet = new ObservableCollection<VehicleImage>();

            // Get all resource names from the current assembly
            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            int i = 0;

            // Iterate through the resources to find those that contain car images
            foreach (var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Cars"))
                {
                    // Add car image to the collection with a unique ID
                    vehicleSet.Add(new VehicleImage { Image = ImageSource.FromResource(resource), Name = $"Car{i}", Id = Guid.NewGuid() });

                    // Limit the collection to 9 items
                    if (i == 8)
                    {
                        return vehicleSet;
                    }
                    i++;
                }
            }
            return vehicleSet;
        }

        /// <summary>
        /// Retrieves a collection of helicopter images from embedded resources.
        /// </summary>
        /// <returns>
        /// An <see cref="ObservableCollection{VehicleImage}"/> containing helicopter images.
        /// </returns>
        public ObservableCollection<VehicleImage> GetHelicopters()
        {
            ObservableCollection<VehicleImage> vehicleSet = new ObservableCollection<VehicleImage>();

            // Get all resource names from the current assembly
            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            int i = 0;

            // Iterate through the resources to find those that contain helicopter images
            foreach (var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Helicopters"))
                {
                    // Add helicopter image to the collection with a unique ID
                    vehicleSet.Add(new VehicleImage { Image = ImageSource.FromResource(resource), Name = $"Heli{i}", Id = Guid.NewGuid() });

                    // Limit the collection to 9 items
                    if (i == 8)
                    {
                        return vehicleSet;
                    }
                    i++;
                }
            }
            return vehicleSet;
        }

        #endregion
    }
}