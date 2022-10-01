using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Estacionamientos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleDeEstacionamiento : ContentPage
    {
        public DetalleDeEstacionamiento()
        {
            InitializeComponent();
        }

        private async void btnReserva_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new WebViewVideos());
            await Browser.OpenAsync("https://mpago.la/2as9Da5");
        }

        private async void btnVerReseñas_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reseñas.Reseñas());
        }
    }
}