using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        public string Title { get; set; } = string.Empty;
    }
}
