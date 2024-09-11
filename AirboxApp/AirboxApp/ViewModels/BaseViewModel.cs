using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirboxApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; } = string.Empty;
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
