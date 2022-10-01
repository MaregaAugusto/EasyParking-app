
using Model;
using Rg.Plugins.Popup.Services;
using ServiceWebApi;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.MiCuenta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MiCuenta : ContentPage
    {
        UserInfo userInfo;
        public MiCuenta()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();


            try
            {
                userInfo = await AccountServiceWebApi.GetUserInfo(App.Username, App.Password);

                if (userInfo != null)
                {
                    if (!string.IsNullOrEmpty(userInfo.Apodo))
                    {
                        labelNombreyApellido.Text = userInfo.Apodo;
                    }
                    else
                    {
                        labelNombreyApellido.Text = userInfo.Nombre + " " + userInfo.Apellido;
                    }
                    labelEmail.Text = userInfo.Email;
                }

            }

            catch (Exception ex)
            {
                await DisplayAlert("Error", Tools.Tools.ExceptionMessage(ex), "Entendido");
            }
        }

        private async void btnEditarNombre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditarNombre(userInfo));
        }

        private async void btnEliminarCuenta_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Advertencia", "¿Seguro desea eliminar su cuenta?" ,"Eliminar","|Cancelar");
            if (result)
            {
                AccountServiceWebApi.UserLock(App.Username);
                Application.Current.MainPage = new NavigationPage(new EasyParking.Views.Login.Login());
            }



        }

        private async void btnCerrarSesion_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Aviso", "¿Desea cerrar sesión?", "Si, cerrar", "Cancelar"))
            {
                Application.Current.Properties.Remove("UsuarioDeAPI");
                Application.Current.Properties.Remove("ContraseñaDeAPI");
                await Application.Current.SavePropertiesAsync();

                if (Application.Current.Properties.ContainsKey("UsuarioDeAPI") == false)
                {
                    Application.Current.Properties.Add("UsuarioDeAPI", "");
                    await Application.Current.SavePropertiesAsync();
                }
                if (Application.Current.Properties.ContainsKey("ContraseñaDeAPI") == false)
                {
                    Application.Current.Properties.Add("ContraseñaDeAPI", "");
                    await Application.Current.SavePropertiesAsync();
                }

             
                this.Navigation.InsertPageBefore(new Login.Login(), this.Navigation.NavigationStack[0]);

                var existingPages = this.Navigation.NavigationStack.ToList();
                this.Navigation.RemovePage(this.Navigation.NavigationStack[1]);
                await this.Navigation.PopAsync();
            }
        }
    }
}