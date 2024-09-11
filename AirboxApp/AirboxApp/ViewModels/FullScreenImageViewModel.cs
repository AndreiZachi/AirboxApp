using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.ViewModels
{
    partial class FullScreenImageViewModel : BaseViewModel
    {
        #region Properties
        [ObservableProperty]
        public ImageSource? fullScreenImage = null;
        [ObservableProperty]
        public Command? backPressed = null;
        #endregion

        #region Constructor
        public FullScreenImageViewModel()
        {
            title = "Full Screen Image";
        }
        #endregion
    }
}
