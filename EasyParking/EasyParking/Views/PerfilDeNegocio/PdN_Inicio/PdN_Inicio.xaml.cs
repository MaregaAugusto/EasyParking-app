﻿using EasyParking.DTO;
using EasyParking.MenuItems;
using EasyParking.Views.Estacionamientos.MisEstacionamientos;
using EasyParking.Views.Generales;
using EasyParking.Views.PerfilDeNegocio.Tarifas.Tarifa;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.PerfilDeNegocio.PdN_Inicio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PdN_Inicio : ContentPage
    {
        public PdN_Inicio()
        {
            InitializeComponent();

            List<ItemDelMenu> ListaItemsDelMenu = new List<ItemDelMenu>();

            int id = 1;
            ItemDelMenu itemMisEstacionamientos = new ItemDelMenu
            {
                Descripcion = "Mis estacionamientos",
                Icono = "SignalParking.png",
                Id = id++
            };

            ListaItemsDelMenu.Add(itemMisEstacionamientos);

            ItemDelMenu itemTarifas = new ItemDelMenu
            {
                Descripcion = "Tarifas",
                Icono = "tarifas.png",
                Id = id++
            };

          //  ListaItemsDelMenu.Add(itemTarifas);

            ItemDelMenu itemReservasActuales = new ItemDelMenu
            {
                Descripcion = "Reservas actuales de clientes",
                Icono = "Reserva.png",
                Id = id++
            };

            ListaItemsDelMenu.Add(itemReservasActuales);



            lwlistado.ItemsSource = ListaItemsDelMenu;


        }

        private async void lwlistado_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {

            var myselecteditem = e.ItemData as ItemDelMenu;

            switch (myselecteditem.Id)
            {
                case 1:
                    await PopupNavigation.Instance.PushAsync(new PopCargando());
                    await Navigation.PushAsync(new MisEstacionamientos());
                    await PopupNavigation.Instance.PopAsync();
                    break;
                case 2:
                    await PopupNavigation.Instance.PushAsync(new PopCargando());
                    await Navigation.PushAsync(new Tarifa(true,true,true));
                    await PopupNavigation.Instance.PopAsync();
                    break;
                    //case 3:
                    //    await PopupNavigation.Instance.PushAsync(new PopCargando());
                    //    await Navigation.PushAsync(new PdN_Inicio());
                    //    await PopupNavigation.Instance.PopAllAsync();
                    //    break;
                    //case 4:
                    //    await PopupNavigation.Instance.PushAsync(new PopCargando());
                    //    await Navigation.PushAsync(new Configuraciones.Configuraciones());
                    //    await PopupNavigation.Instance.PopAllAsync();
                    //    break;
                    //case 5:
                    //    await PopupNavigation.Instance.PushAsync(new PopCargando());
                    //    await Navigation.PushAsync(new Inicio.Inicio());
                    //    await PopupNavigation.Instance.PopAllAsync();
                    //    break;
            }
        }
    }
}