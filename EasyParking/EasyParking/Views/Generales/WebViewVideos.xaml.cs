
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Generales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewVideos : ContentPage
    {
        public WebViewVideos()
        {
            InitializeComponent();
            webview.Source = "https://mpago.la/1KpsiaL";
        }
    }
}