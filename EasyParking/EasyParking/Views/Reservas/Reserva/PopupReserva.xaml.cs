using EasyParking.Views.MisVehiculos;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Reservas.Reserva
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupReserva  
    {
        public PopupReserva()
        {
            InitializeComponent();
            //radiobuttonAuto.IsChecked = true;
        }

        private async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }

        private async void btnMisVehiculos_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupMisVehiculos());
        }

        private async void btnNuevoVehiculo_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupVehiculo());
        }
    }
}