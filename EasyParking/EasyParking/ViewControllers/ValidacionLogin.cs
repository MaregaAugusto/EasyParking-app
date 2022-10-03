using EasyParking.Views.Inicio;
using EasyParking.Views.Login;
using EasyParking.Views.Menu;
using ServiceWebApi.DTO;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EasyParking.ViewControllers
{
    public class ValidacionLogin : ContentPage
    {
        public ValidacionLogin()
        {
            if (Application.Current.Properties.ContainsKey("FechaExpiracionToken") == false)
            {
                Application.Current.Properties.Add("FechaExpiracionToken", null);
                Application.Current.SavePropertiesAsync();
            }
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                AsignarOCrearCredenciales();

                // ¿HAY INTERNET? SI
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    // ¿HAY CREDENCIALES GUARDADAS PREVIAMENTE? NO
                    if ((string.IsNullOrWhiteSpace(App.cloudData.UsuarioDeAPI)) | (string.IsNullOrWhiteSpace(App.cloudData.ContraseñaDeAPI)))
                    {
                        App._mainPage = new NavigationPage(new Login());
                    }
                    else // ¿HAY CREDENCIALES GUARDADAS PREVIAMENTE? SI
                    {
                        // INTENTO LOGEARLO 
                        MsjResultadoDeAccion msjResultado = await Account.Account.LoginAPI(App.cloudData.URLDeAPI, App.cloudData.UsuarioDeAPI, App.cloudData.ContraseñaDeAPI);

                        if (msjResultado.Error) // SI HUBO ERROR LO NOTIFICO CON LA PAGINA DE ERROR
                        {
                            App._mainPage = new NavigationPage(new EasyParking.Views.Generales.InternetNotAvailable());
                        }
                        else // NO HUBO ERROR, LO MANDO AL INICIO, TODO OK
                        {
                            App.UserInfo = await Account.Account.GetUserInfo(App.cloudData.UsuarioDeAPI); // Obtengo los datos del usuario para trabajar en la app
                            App._mainPage = new NavigationPage(new MenuContainer(new Inicio()));
                        }
                    }
                }
                else // ¿HAY INTERNET? NO
                {
                    // ¿PERO SI HAY CREDENCIALES GUARDADAS PREVIAMENTE? SI, LO MANDO AL INICIO // AUNQUE NO VA PODER HACER NADA PORQUE NO HAY INTERNET
                    if ((!string.IsNullOrWhiteSpace(App.cloudData.UsuarioDeAPI)) | (!string.IsNullOrWhiteSpace(App.cloudData.ContraseñaDeAPI)))
                    {
                        App._mainPage = new NavigationPage(new MenuContainer(new Inicio()));
                    }
                    else  // ¿PERO SI HAY CREDENCIALES GUARDADAS PREVIAMENTE? NO, NOTIFICO CON LA PAGINA DE ERROR PORQUE NO HAY INTERNET Y TAMPOCO HAY
                    {     // CERDENCIALES, POR LO QUE NO LO PUEDO MANDAR AL LOGIN PARA QUE HAGA EL PROCESO DE LOGEO YA QUE NO HAY INTERNET
                        App._mainPage = new NavigationPage(new EasyParking.Views.Generales.InternetNotAvailable());
                    }
                }

                Application.Current.MainPage = App._mainPage;
            }
            catch (Exception ex)
            {
                //  Tools.Tools.ExecuteSentry(this.GetType().Name, Tools.Tools.ExtraerNombreMetodo(MethodBase.GetCurrentMethod().ReflectedType.Name), App.cloudData.NombreEXE, App.cloudData.UsuarioDeAPI, App.cloudData.URLDeAPI, App.ModalidadDeLaApp.ToString(), Tools.Tools.ExceptionMessage(ex));
                await DisplayAlert("Error", Tools.Tools.ExceptionMessage(ex), "Entendido");
            }
        }

        public async void AsignarOCrearCredenciales()
        {
            try
            {

                if (Application.Current.Properties.ContainsKey("UsuarioDeAPI") == false)
                {
                    Application.Current.Properties.Add("UsuarioDeAPI", "");
                    await Application.Current.SavePropertiesAsync();
                }
                else
                {
                    App.cloudData.UsuarioDeAPI = Application.Current.Properties["UsuarioDeAPI"] as string;
                }

                if (Application.Current.Properties.ContainsKey("ContraseñaDeAPI") == false)
                {
                    Application.Current.Properties.Add("ContraseñaDeAPI", "");
                    await Application.Current.SavePropertiesAsync();
                }
                else
                {
                    App.cloudData.ContraseñaDeAPI = Application.Current.Properties["ContraseñaDeAPI"] as string;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
