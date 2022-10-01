using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace EasyParking.ViewControllers
{
    public class MensajesViewControllers : ContentPage
    {
        /// <summary>
        /// Chquea si hay conexcion a internet e informa en pantalla si fallo, sino deja seguir ejecutando el programa
        /// </summary>
        public async void ChequearConexion()
        {
            var current = Connectivity.NetworkAccess;
            while (current != NetworkAccess.Internet)
            {
                await DisplayAlert("¡Ups!", "No hay conexión", "Volver a Intentar", "Cancelar");
                current = Connectivity.NetworkAccess;
            }
        }

        public async Task MostrarMensaje(string msj)
        {
            await DisplayAlert("¡Ups!", msj, "Entendido");
        }

        public async Task MostrarMensaje(string Titulo, string msj)
        {
            await DisplayAlert(Titulo, msj, "Entendido");
        }

    }
}
