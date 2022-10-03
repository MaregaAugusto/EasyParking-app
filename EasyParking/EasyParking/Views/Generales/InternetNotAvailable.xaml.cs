using System;

using Xamarin.Forms;
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