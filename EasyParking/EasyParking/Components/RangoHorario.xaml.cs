using Syncfusion.XForms.ComboBox;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RangoHorario : ContentView
    {
        public RangoHorario()
        {
            InitializeComponent();

            List<string> Horas = new List<string>();
            List<string> Minutos = new List<string>();

            for (int i = 0; i < 24; i++)
            {
                Horas.Add(i.ToString());
            }

            for (int i = 0; i < 60; i += 5)
            {
                Minutos.Add(i.ToString());
            }


            comboboxHora_Desde.ComboBoxSource = Horas;
            comboboxHora_Hasta.DataSource = Horas;

            comboboxMinuto_Desde.DataSource = Minutos;
            comboboxMinuto_Hasta.DataSource = Minutos;

            ComboboxHora_Desde = comboboxHora_Desde;
        }


        private SfComboBox _comboboxHora_Desde { get; set; }
        public SfComboBox ComboboxHora_Desde
        {
            get { return _comboboxHora_Desde; }
            set
            {
                comboboxHora_Desde = _comboboxHora_Desde;
            }
        }

        public delegate void OnClicked_EliminarDelegate();
        public event EventHandler OnClicked_Eliminar;

        public delegate void ValueChanged_comboboxHora_DesdeDelegate();
        public event EventHandler ValueChanged_comboboxHora_Desde;

        public delegate void ValueChanged_comboboxMinuto_DesdeDelegate();
        public event EventHandler ValueChanged_comboboxMinuto_Desde;

        public delegate void ValueChanged_comboboxHora_HastaDelegate();
        public event EventHandler ValueChanged_comboboxHora_Hasta;

        public delegate void ValueChanged_omboboxMinuto_HastaDelegate();
        public event EventHandler ValueChanged_omboboxMinuto_Hasta;


        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            OnClicked_Eliminar?.Invoke(this, EventArgs.Empty);

        }

        private void comboboxHora_Desde_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            ValueChanged_comboboxHora_Desde?.Invoke(this, EventArgs.Empty);
        }

        private void comboboxMinuto_Desde_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            ValueChanged_comboboxMinuto_Desde?.Invoke(this, EventArgs.Empty);
        }

        private void comboboxHora_Hasta_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            ValueChanged_comboboxHora_Hasta?.Invoke(this, EventArgs.Empty);
        }

        private void comboboxMinuto_Hasta_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            ValueChanged_omboboxMinuto_Hasta?.Invoke(this, EventArgs.Empty);
        }
    }
}