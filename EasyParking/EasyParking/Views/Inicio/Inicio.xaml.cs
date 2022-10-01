using EasyParking.Views.Estacionamientos;
using EasyParking.Views.Generales;
using EasyParking.Views.Reservas.Reserva;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Inicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();


            //ahora calculo la distancia entre la posicion actual recien medida y la ultima guardada
            Location posicion_actual = new Location(-27.4528818, -58.9786916);
            Location posicion_ultima = new Location(-27.4552894, -58.9882253);
            double kilometros = Location.CalculateDistance(posicion_actual, posicion_ultima, DistanceUnits.Kilometers); // resultado en kilometros
            lwlisado.ItemsSource = null;
            lwlisado.ItemsSource = Tools.Tools.GetEstacionamientosMock();

        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    lwlisado.ItemsSource = null;
        //   lwlisado.ItemsSource = Tools.Tools.GetEstacionamientosMock();

        //}

        private async void Card_Parking_OnClicked_Reserva(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupReserva());
        }

        private async void Card_Parking_OnClicked_VerMas(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopCargando());
            await Navigation.PushAsync(new DetalleDeEstacionamiento());
            await PopupNavigation.Instance.PopAsync();

        }

        private async void Card_Parking_OnClicked_VerMapa(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("geo:0,0?q=José+Hernández+465+Resistencia+Chaco");
            //await Launcher.OpenAsync("geo:0,0?q=Av. Madariaga+278+Goya+Corrientes");
            //await Launcher.OpenAsync("geo:0,0?q=297+Luis+Agote+GoyaCorrientes");}
        }

        private async void navBar_SearchBar_Focused(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Busqueda());
        }
    }
}