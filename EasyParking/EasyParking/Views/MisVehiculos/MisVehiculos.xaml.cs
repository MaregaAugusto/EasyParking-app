using Rg.Plugins.Popup.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.MisVehiculos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MisVehiculos : ContentPage
    {
        public MisVehiculos()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupVehiculo());
        }
    }
}