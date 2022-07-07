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

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Eliminar Estacionamiento", "¿seguro desea eliminarlo?", "Si, eliminar", "No");

            if (result)
            {
                Tools.Tools.Messages("Estacionamiento eliminado");
            }
        }

        private async void btnPausar_Clicked(object sender, EventArgs e)
        {
           
            bool result = await DisplayAlert("Pausar publicación", "¿seguro desea pausarla?", "Si, pausar", "No");

            if (result)
            {
                Tools.Tools.Messages("Publicación pausada");
            }
        }
    }
}