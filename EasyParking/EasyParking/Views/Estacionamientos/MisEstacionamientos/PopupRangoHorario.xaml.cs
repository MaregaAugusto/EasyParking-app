using EasyParking.Components;
using Rg.Plugins.Popup.Services;
using Syncfusion.XForms.ComboBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Estacionamientos.MisEstacionamientos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupRangoHorario  
    {
        List<RangoH> lista = new List<RangoH>();
        int id = 0;

        public PopupRangoHorario()
        {
            InitializeComponent();





            RangoH r1 = new RangoH();
            RangoH r2 = new RangoH();
            RangoH r3 = new RangoH();
            RangoH r4 = new RangoH();


            r1.Id = id++;
            r2.Id = id++;
            r3.Id = id++;
            r4.Id = id++;

            //  r2.Id = id++;


            lista.Add(r1); 
            lista.Add(r2);
            lista.Add(r3);
            lista.Add(r4);

            //   lista.Add(r2);

            BindingContext = lista;


        }

        public delegate Task MyDelegate(List<RangoH> parameter);
        public event MyDelegate MyEvent;

        public class RangoH
        {
            public int DesdeHora { get; set; }
            public int DesdeMinuto { get; set; }
            public int HastaHora { get; set; }
            public int HastaMinuto { get; set; }
            public int Id { get; set; }

        }

        private async Task CloseAllPopup(List<RangoH> parametro)
        {

            try
            {
                await MyEvent(parametro);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Errot ...", ex.Message, "Entendido");
            }
            await Navigation.PopAsync();


        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            RangoH r = new RangoH();
            r.Id = id++;

            lista.Add(r);
            BindingContext = null;
            BindingContext = lista;
        }

      
        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                BindingContext = null;

                var btn = sender as ImageButton;
                var detalle = btn?.BindingContext as RangoH;

                List<RangoH> aux = new List<RangoH>();

                BindingContext = aux;
                //foreach (var item in lista)
                //{
                //    if (item.Id != detalle.Id)
                //    {
                //        aux.Add(item);
                //    }
                //}

                //lista = new List<RangoH>();
                //lista = aux;

                 lista.Remove(detalle);

                foreach (var item in lista)
                {
                    aux.Add(item);
                }


                BindingContext = aux;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                BindingContext = lista;

            }
        }

        private void comboboxHora_Desde_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            var btn = sender as SfComboBox;
            var detalle = btn?.BindingContext as RangoH;


            foreach (var item in lista)
            {
                if (item.Id == detalle.Id)
                {
                    item.DesdeHora = Convert.ToInt32(e.Value); 
                }
            }


        }

        private void comboboxMinuto_Desde_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            var btn = sender as SfComboBox;
            var detalle = btn?.BindingContext as RangoH;


            foreach (var item in lista)
            {
                if (item.Id == detalle.Id)
                {
                    item.DesdeMinuto = Convert.ToInt32(e.Value);
                }
            }

        }

        private void comboboxHora_Hasta_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            var btn = sender as SfComboBox;
            var detalle = btn?.BindingContext as RangoH;


            foreach (var item in lista)
            {
                if (item.Id == detalle.Id)
                {
                    item.HastaHora = Convert.ToInt32(e.Value);
                }
            }

        }

        private void comboboxMinuto_Hasta_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            var btn = sender as SfComboBox;
            var detalle = btn?.BindingContext as RangoH;


            foreach (var item in lista)
            {
                if (item.Id == detalle.Id)
                {
                    item.HastaMinuto = Convert.ToInt32(e.Value);
                }
            }

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnCancelar_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(); 
        }
    }
}