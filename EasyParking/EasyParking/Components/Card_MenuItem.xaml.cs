using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Components
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Card_MenuItem : ContentView
    {
        public Card_MenuItem()
        {
            InitializeComponent();
        }
        private Color _borderContent_BackgroundColor { get; set; }
        public Color BorderContent_BackgroundColor
        {
            get { return _borderContent_BackgroundColor; }
            set
            {
                borderContent.BackgroundColor = value;
            }
        }

        private Color _borderContent_BorderColor { get; set; }
        public Color BorderContent_BorderColor
        {
            get { return _borderContent_BorderColor; }
            set
            {
                borderContent.BorderColor = value;
            }
        }

        private Color _labelCantidad_TextColor { get; set; }
        public Color LabelCantidad_TextColor
        {
            get { return _labelCantidad_TextColor; }
            set
            {
                labelCantidad.TextColor = value;
            }
        }


        private Color _frameCantidad_BackgroundColor { get; set; }
        public Color FrameCantidad_BackgroundColor
        {
            get { return _frameCantidad_BackgroundColor; }
            set
            {
                frameCantidad.BackgroundColor = value;
            }
        }

        private Color _frameCantidad_BorderColor { get; set; }
        public Color FrameCantidad_BorderColor
        {
            get { return _frameCantidad_BorderColor; }
            set
            {
                frameCantidad.BorderColor = value;
            }
        }

        private Color _labelDescripcion_TextColor { get; set; }
        public Color LabelDescripciond_TextColor
        {
            get { return _labelDescripcion_TextColor; }
            set
            {
                labelDescripcion.TextColor = value;
            }
        }

        private Color _labelSub_Descripcion_TextColor { get; set; }
        public Color LabelSub_Descripciond_TextColor
        {
            get { return _labelSub_Descripcion_TextColor; }
            set
            {
                lableSub_Descripcion.TextColor = value;
            }
        }
    }
}
