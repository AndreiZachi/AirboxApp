using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.Models
{
    public class VehicleImages : ObservableCollection<ImageSource>
    {
        public ImageSource? Image { get; set; } 
    }
}
