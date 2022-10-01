using Model;
using ServiceWebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.MiCuenta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarNombre : ContentPage
    {
        private UserInfo _userInfo;
        public EditarNombre(UserInfo userInfo)
        {
            InitializeComponent();
            _userInfo = userInfo;
            entryApellido.Text = userInfo.Apellido;
            entryNombre.Text = userInfo.Nombre;
            //entryApodo.Text = userInfo.
        }

        private async void btnGuardarCambios_Clicked(object sender, EventArgs e)
        {
            try
            {
               
                _userInfo.Apodo = entryApodo.Text.Trim();

                AccountServiceWebApi.Update(_userInfo, App.Username, App.Password);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", Tools.Tools.ExceptionMessage(ex), "Entendido");
            }
        }
    }
}