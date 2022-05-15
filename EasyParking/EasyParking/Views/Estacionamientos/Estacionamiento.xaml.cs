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

namespace EasyParking.Views.Estacionamientos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Estacionamiento : ContentPage
    {
        public Estacionamiento()
        {
            InitializeComponent();
            frameTarifaAuto.IsVisible = frameTarifaCamioneta.IsVisible = frameTarifaMoto.IsVisible = false;
            entryCantidadAuto.IsEnabled = entryCantidadCamioneta.IsEnabled = entryCantidadMoto.IsEnabled = false;

        }

        private void comboBoxTipoDeEstado_SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        {

        }

        private void comboBoxTipoDeLugar_SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        {

        }

        /// /////// No se usan /// ///////
        private async void btnAutoTarifa_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupTarifa("Auto"));
        }

        private async void btnCamionetaTarifa_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupTarifa("Camioneta"));
        }

        private async void btnMotoTarifa_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupTarifa("Moto"));
        }
        /// /////// //////// /// ///////

        private void checkBoxAuto_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((bool)checkBoxAuto.IsChecked)
            {
                frameTarifaAuto.IsVisible = entryCantidadAuto.IsEnabled = true;
            }
            else
            {
                frameTarifaAuto.IsVisible = entryCantidadAuto.IsEnabled = false;

            }
        }

        private void checkBoxCamioneta_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((bool)checkBoxCamioneta.IsChecked)
            {
                frameTarifaCamioneta.IsVisible = entryCantidadCamioneta.IsEnabled= true;
            }
            else
            {
                frameTarifaCamioneta.IsVisible = entryCantidadCamioneta.IsEnabled = false;
            }
        }

        private void checkBoxMoto_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((bool)checkBoxMoto.IsChecked)
            {
                frameTarifaMoto.IsVisible = entryCantidadMoto.IsEnabled = true;
            }
            else
            {
                frameTarifaMoto.IsVisible = entryCantidadMoto.IsEnabled = false;
            }
        }
    }
}