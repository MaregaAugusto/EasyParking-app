using EasyParking.Views.Reseñas;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Reservas.MisReservas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MisReservas : ContentPage
    {
        public MisReservas()
        {
            InitializeComponent();
        }



        private async void btnCancelarReserva_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Cancelar Reserva", "¿seguro desea cancelarla?", "Si, cancelar", "No");

            if (result)
            {
                Tools.Tools.Messages("Reserva eliminada");
            }
        }

        private async void btnAgregarReseña_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgregarReseña());
        }
    }
}