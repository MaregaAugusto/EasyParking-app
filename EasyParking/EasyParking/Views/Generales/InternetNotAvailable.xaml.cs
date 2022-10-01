using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Generales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InternetNotAvailable : ContentPage
    {
        public InternetNotAvailable()
        {
            InitializeComponent();
        }

        private void btnCerrarApp_Clicked(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}