using EasyParking.Views.Estacionamientos;
using EasyParking.Views.Inicio;
using EasyParking.Views.Login;
using EasyParking.Views.PerfilDeNegocio.Tarifas.Tarifa;
using EasyParking.Views.Reservas.Reserva;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking
{
    public partial class App : Application
    {
        public static List<Modelo.Estacionamiento> Estacionamientos { get; set; } = new List<Modelo.Estacionamiento>();
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjcyODEwQDMyMzAyZTMyMmUzMG5CS0JZb1FVSWgxeXR4cml5S1VQb3dJdGJ3YlgvbUl1V3ppNE1VL25ReFk9");

            InitializeComponent();

          // MainPage = new NavigationPage(new EasyParking.Views.Menu.MenuContainer(new Inicio()));
            //MainPage = new NavigationPage(new EasyParking.Views.Menu.MenuContainer(new Estacionamiento()));
            MainPage = new NavigationPage(new Login());
           // MainPage = new NavigationPage(new Registrarme());
            //MainPage = new NavigationPage(new IniciarSesion());

        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
