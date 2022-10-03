using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Generales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupEditSimpleData
    {
        public PopupEditSimpleData()
        {
            InitializeComponent();
        }

        public delegate void MyDelegate(string parameter);
        public event MyDelegate MyEvent;

        private async Task CloseAllPopup(string parametro)
        {
            try
            {
                MyEvent(parametro);
            }
            catch (Exception ex)
            {
                //Tools.Tools.ExecuteSentry(App.NombreEmpresa, Tools.Tools.GetPackageInfo(), Tools.Tools.GetVersionCode(), this.GetType().Name, Tools.Tools.ExtraerNombreMetodo(System.Reflection.MethodBase.GetCurrentMethod().ReflectedType.Name), App.cloudData.UsuarioDeAPI, App.webApiUri, await Tools.Tools.ExceptionMessage(ex), DateTime.Now);

                DisplayAlert("Error", Tools.Tools.ExceptionMessage(ex), "Entendido");
            }
            finally
            {
                await PopupNavigation.Instance.PopAsync();
            }
        }
        private async void BotonCancelar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }

        private async void BotonGuardar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryTelefono.Text) && entryTelefono.Text.Trim().Length == 10)
            {
                await CloseAllPopup(entryTelefono.Text.Trim());
            }
            else
            {
                await DisplayAlert("Aviso", "Debe ingresar alguna dirección", "Entendido");
            }
        }
    }
}
