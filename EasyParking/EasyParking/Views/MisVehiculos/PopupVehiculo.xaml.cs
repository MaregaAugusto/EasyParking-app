using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.MisVehiculos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupVehiculo
    {
        public PopupVehiculo()
        {
            InitializeComponent();
        }

        private async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();

        }
    }
}