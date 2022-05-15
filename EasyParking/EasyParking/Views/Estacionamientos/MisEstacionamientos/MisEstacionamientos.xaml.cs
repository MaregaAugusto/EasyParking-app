using EasyParking.Views.Generales;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Estacionamientos.MisEstacionamientos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MisEstacionamientos : ContentPage
    {
        public MisEstacionamientos()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopCargando());
            await Navigation.PushAsync(new Estacionamiento());
            await PopupNavigation.Instance.PopAsync();
        }
    }
}