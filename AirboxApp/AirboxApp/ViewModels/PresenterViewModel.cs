using AirboxApp.Enums;
using AirboxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.ViewModels
{
    public class PresenterViewModel : BaseViewModel
    {

        #region Properties
        public VehicleImages? Cars { get; set; }
        public VehicleImages? Helicopters { get; set; }
        public VehicleImages? Boats { get; set; }
        public VehicleImages? SelectedSet { get; set; }  
        #endregion

        #region Constructor
        public PresenterViewModel()
        {
            Title = "Image Presenter";
        }
        #endregion

        #region Commands
        public Command ChangeImageSet => new Command((sender) =>
        {
            var type = sender is null ? ImageSetType.CarType : (ImageSetType)sender;
            switch (type)
            {
                case ImageSetType.CarType:
                    break;
                case ImageSetType.BoatType:
                    break;
                case ImageSetType.HelicopterType:
                    break;
                default:
                    throw new NotImplementedException();
            }
        });

        #endregion
    }
}
