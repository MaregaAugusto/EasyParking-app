using EasyParking.Views.Generales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Reservas.Reserva
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reserva : ContentPage
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private async void btnReserva_Clicked(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new WebViewVideos());
            await Browser.OpenAsync("https://mpago.la/2as9Da5");
        }
    }
}