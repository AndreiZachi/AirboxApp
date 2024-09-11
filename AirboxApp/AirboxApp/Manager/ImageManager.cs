using AirboxApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.Manager
{
    public class ImageManager
    {


        #region Methods
        public ObservableCollection<VehicleImage> GetBoats()
        {
            ObservableCollection<VehicleImage> vehicleSet = new ObservableCollection<VehicleImage>();


            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            int i = 0;
            foreach (var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Boats"))
                {
                    vehicleSet.Add(new VehicleImage { Image = ImageSource.FromResource(resource), Id = Guid.NewGuid() });
                }
                if (i == 8)
                {
                    return vehicleSet;
                }
                i++;

            }
            return vehicleSet;
        }

        public ObservableCollection<VehicleImage> GetCars()
        {
            ObservableCollection<VehicleImage> vehicleSet = new ObservableCollection<VehicleImage>();

            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            int i = 0;
            foreach (var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Cars"))
                {
                    vehicleSet.Add(new VehicleImage { Image = ImageSource.FromResource(resource), Id = Guid.NewGuid() });
                }
                if (i == 8)
                {
                    return vehicleSet;
                }
                i++;

            }
            return vehicleSet;
        }

        public ObservableCollection<VehicleImage> GetHelicopters()
        {
            ObservableCollection<VehicleImage> vehicleSet = new ObservableCollection<VehicleImage>();

            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            int i = 0;
            foreach (var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Helicopters"))
                {
                    vehicleSet.Add(new VehicleImage { Image = ImageSource.FromResource(resource), Id = Guid.NewGuid() });
                }
                if (i == 8)
                {
                    return vehicleSet;
                }
                i++;
            }
            return vehicleSet;
        }
        #endregion
    }
}
