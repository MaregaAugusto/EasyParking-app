using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.PerfilDeNegocio.MarcarSalida
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MarcarSalida : ContentPage
    {
        public MarcarSalida()
        {
            InitializeComponent();
        }

        private async void btnSehaIdo_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Salida registrada", "¿Desea realizar algún comentario y calificación del cliente?", "Si", "Ahora no");
        }
    }
}