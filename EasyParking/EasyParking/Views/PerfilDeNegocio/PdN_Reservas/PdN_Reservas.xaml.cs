using Rg.Plugins.Popup.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.PerfilDeNegocio.PdN_Reservas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PdN_Reservas : ContentPage
    {
        public PdN_Reservas()
        {
            InitializeComponent();
        }

        private async void btnHaLlegado_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupVerificacionLlegada());
        }

        private async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Cancelar Reserva", "¿seguro desea cancelarla?", "Si, cancelar", "No");
        }
    }
}