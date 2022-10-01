using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Card_Parking : ContentView
    {
        public Card_Parking()
        {
            InitializeComponent();
        }

        public delegate void OnClicked_ReservaDelegate();
        public event EventHandler OnClicked_Reserva;

        public delegate void OnClicked_VerMasDelegate();
        public event EventHandler OnClicked_VerMas;

        public delegate void OnClicked_VerMapaDelegate();
        public event EventHandler OnClicked_VerMapa;

        private async void btnReserva_Clicked(object sender, EventArgs e)
        {
            OnClicked_Reserva?.Invoke(this, EventArgs.Empty);

        }

        private async void btnVerMas_Clicked(object sender, EventArgs e)
        {
            OnClicked_VerMas?.Invoke(this, EventArgs.Empty);
        }

        private async void btnVerMapa_Clicked(object sender, EventArgs e)
        {
            OnClicked_VerMapa?.Invoke(this, EventArgs.Empty);
        }

        private void imagenCard_Clicked(object sender, EventArgs e)
        {

        }
    }
}