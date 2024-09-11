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
        public ObservableCollection<ImageSource> GetBoats()
        {
            ObservableCollection<ImageSource>? vehicleSet = new ObservableCollection<ImageSource>();

            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            foreach(var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Boats"))
                {
                    vehicleSet.Add(ImageSource.FromResource(resource));
                }
            }
            return vehicleSet;
        }

        public ObservableCollection<ImageSource> GetCars()
        {
            ObservableCollection<ImageSource>? vehicleSet = new ObservableCollection<ImageSource>();

            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            foreach (var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Cars"))
                {
                    vehicleSet.Add(ImageSource.FromResource(resource));
                }
            }
            return vehicleSet;
        }

        public ObservableCollection<ImageSource> GetHelicopters()
        {
            ObservableCollection<ImageSource>? vehicleSet = new ObservableCollection<ImageSource>();

            var assemblyResourcesNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            foreach (var resource in assemblyResourcesNames)
            {
                if (resource.Contains("Images.Helicopters"))
                {
                    vehicleSet.Add(ImageSource.FromResource(resource));
                }
            }
            return vehicleSet;
        }
    }
}
