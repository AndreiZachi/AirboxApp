using AirboxApp.ViewModels;

namespace AirboxApp.Views;

public partial class PresenterPage : ContentPage
{
	public PresenterPage()
	{
		InitializeComponent();
		var vm = BindingContext as PresenterViewModel;
		//vm.popupService = this.po
	}
}