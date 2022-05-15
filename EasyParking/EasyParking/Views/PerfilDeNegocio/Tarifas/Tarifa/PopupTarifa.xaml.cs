using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.PerfilDeNegocio.Tarifas.Tarifa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupTarifa
    {
        public PopupTarifa(string vehiculo)
        {
            InitializeComponent();
            labelTipoDeVehiculo.Text = "Tarifa: " + vehiculo;
        }

        private async  void btnCancelar_Clicked(object sender, System.EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }

    }
}