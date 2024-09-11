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

        /// <summary>
        /// The image to be displayed in full-screen mode.
        /// </summary>
        [ObservableProperty]
        public ImageSource? fullScreenImage = null;

        /// <summary>
        /// Command to handle the back button press, typically used to close the full-screen view.
        /// </summary>
        [ObservableProperty]
        public Command? backPressed = null;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FullScreenImageViewModel"/> class.
        /// Sets the title for the full-screen image view.
        /// </summary>
        public FullScreenImageViewModel()
        {
            title = "Full Screen Image";
        }

        #endregion
    }
}
