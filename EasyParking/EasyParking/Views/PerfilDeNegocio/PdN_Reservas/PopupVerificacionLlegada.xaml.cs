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
    public partial class PopupVerificacionLlegada 
    {
        public PopupVerificacionLlegada()
        {
            InitializeComponent();
        }

        private async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();

        }
    }
}