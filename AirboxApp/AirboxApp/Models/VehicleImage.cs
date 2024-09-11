using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.Models
{
    public class VehicleImage : BaseModel
    {
        #region Properties
        public ImageSource? Image { get; set; }        
        public Guid Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
