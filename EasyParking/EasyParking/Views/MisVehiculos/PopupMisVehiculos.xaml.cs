using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.MisVehiculos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupMisVehiculos  
    {
        public PopupMisVehiculos()
        {
            InitializeComponent();

            Vehiculo vehiculo = new Vehiculo
            {
                Tipo = "Auto",
                Patente = "AS 654 AS"
            };

            Vehiculo vehiculo2 = new Vehiculo
            {
                Tipo = "Moto",
                Patente = "AS698"
            };

            List<Vehiculo> lista = new List<Vehiculo>();
            lista.Add(vehiculo);
            lista.Add(vehiculo2);
            lwlistado.ItemsSource = lista;
        }

        class Vehiculo
        {
            public string Tipo { get; set; }
            public string Patente { get; set; }
        }

        private async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }
    }
}