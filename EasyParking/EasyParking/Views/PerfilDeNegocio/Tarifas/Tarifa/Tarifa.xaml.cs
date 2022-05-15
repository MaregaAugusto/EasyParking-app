using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.PerfilDeNegocio.Tarifas.Tarifa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tarifa : ContentPage
    {
        public Tarifa(bool Auto, bool Moto, bool Camioneta)
        {
            InitializeComponent();

            _ = DisplayAlert("Aviso", "Las opciones para tarifas que se muestran aquí " +
                                    "son según lo indicado anteriormente" +
                                    " sobre los vehículos que se contemplarán " +
                                    "en el estacionamiento", "Entendido");


            stackAutos.IsVisible = Auto;
            stackCamionetas.IsVisible = Camioneta;
            stackMotos.IsVisible = Moto;
        }


    }
}