using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.PerfilDeNegocio.PdN_Reservas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PdN_Reservas : ContentPage
    {
        public PdN_Reservas()
        {
            InitializeComponent();
        }

        private async void btnHaLlegado_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupVerificacionLlegada());
        }
    }
}