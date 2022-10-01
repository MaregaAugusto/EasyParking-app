using EasyParking.Views.Generales;
using Model;
using Model.Enums;
using Rg.Plugins.Popup.Services;
using ServiceWebApi;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrarme : ContentPage
    {
        TipoDeDocumento tipoDeDocumento = TipoDeDocumento.NONE;

        public Registrarme()
        {
            InitializeComponent();
            comboBoxTipoDeDocumento.Text = "DNI";  // Por defecto se pone a DNI como primera opcion.
            tipoDeDocumento = TipoDeDocumento.DNI; // 
            CargarTipoDeDocumentos();
        }

        public void CargarTipoDeDocumentos()
        {
            List<string> ListaTipoDeDocumentos = new List<string>();

            foreach (var item in System.Enum.GetValues(typeof(TipoDeDocumento)))
            {
                if (item.ToString() != TipoDeDocumento.NONE.ToString())
                {
                    ListaTipoDeDocumentos.Add(item.ToString());

                }
            }
            comboBoxTipoDeDocumento.DataSource = ListaTipoDeDocumentos;
        }


        private async void btnRegistrarme_Clicked(object sender, EventArgs e)
        {
            try
            {
                await PopupNavigation.Instance.PushAsync(new PopCargando());

                UserInfo userInfo = new UserInfo();
                userInfo.Nombre = entryNombre.Text.ToLower();
                userInfo.Apellido = entryApellido.Text.ToLower();
                userInfo.Email = entryEmail.Text.ToLower();
                userInfo.NumeroDeDocumento = entryDNI.Text;
                userInfo.TipoDeDocumento = tipoDeDocumento;
                userInfo.Telefono = entryTelefono.Text;
                userInfo.Password = entryContraseña.Text;

                await PopupNavigation.Instance.PushAsync(new PopCargando());
                AccountServiceWebApi.CreateUser(userInfo);

                await PopupNavigation.Instance.PopAsync();
                await Navigation.PushAsync(new IniciarSesion());
                DisplayAlert("Registro exitoso", "Ya puede logearse", "Entendido");
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PopAsync();
                await DisplayAlert("Error", Tools.Tools.ExceptionMessage(ex), "Entendido");
            }

        }

        private void comboBoxTipoDeDocumento_SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        {
            tipoDeDocumento = (TipoDeDocumento)System.Enum.Parse(typeof(TipoDeDocumento), e.Value.ToString());
        }
    }
}