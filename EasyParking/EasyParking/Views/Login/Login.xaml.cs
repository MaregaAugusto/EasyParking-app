using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnOlvideMiContraseña_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlvideMiContraseña());
        }

        private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IniciarSesion());
        }

        private async void btnRegistrarme_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrarme());
        }
    }
}