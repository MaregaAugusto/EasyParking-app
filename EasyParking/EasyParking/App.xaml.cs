﻿using EasyParking.Views.Inicio;
using EasyParking.Views.PerfilDeNegocio.Tarifas.Tarifa;
using EasyParking.Views.Reservas.Reserva;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjI4MjcxQDMyMzAyZTMxMmUzMEpHU2lJMXV3ZkYzZUlLUFUrWFJ1eFhVUjlCN2Vsakh6M1lhLzUydE1xNHc9");

            InitializeComponent();

            MainPage = new NavigationPage(new EasyParking.Views.Menu.MenuContainer(new Inicio()));
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