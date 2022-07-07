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
    public partial class ReseñaEnviada : ContentPage
    {
        public ReseñaEnviada()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            // Create a task and supply a user delegate by using a lambda expression.
            Task taskA = new Task(async () => await ExecueteAnimation());
            // Start the task.
            taskA.Start();
        }
        private async Task ExecueteAnimation()
        {
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    await imagen.ScaleTo(1.2, 1000);
                    await Task.Delay(400);
                    await imagen.ScaleTo(1, 500);
                }
            }
            catch (Exception ex)
            {
               // Tools.Tools.ExecuteSentry(App.NombreEmpresa, Tools.Tools.GetPackageInfo(), Tools.Tools.GetVersionCode(), this.GetType().Name, Tools.Tools.ExtraerNombreMetodo(System.Reflection.MethodBase.GetCurrentMethod().ReflectedType.Name), App.cloudData.UsuarioDeAPI, App.webApiUri, await Tools.Tools.ExceptionMessage(ex), DateTime.Now);

            }
        }
    }
}