using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Reseñas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgregarReseña : ContentPage
    {
        public AgregarReseña()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReseñaEnviada());
        }
    }
}