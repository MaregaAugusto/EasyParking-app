using EasyParking.Views.Reseñas;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.PerfilDeNegocio.HistorialDeReservas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistorialDeReservas : ContentPage
    {
        public HistorialDeReservas()
        {
            InitializeComponent();
        }

        private async void btnAgregarReseña_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AgregarReseña());
        }
    }
}