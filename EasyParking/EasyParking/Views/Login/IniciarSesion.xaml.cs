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
    public partial class IniciarSesion : ContentPage
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new Inicio.Inicio());

            Application.Current.MainPage = new NavigationPage(new EasyParking.Views.Menu.MenuContainer(new Inicio.Inicio()));
        }
    }
}