using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace EasyParking.DTO
{
    public class ItemDelMenu : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int Id { get; set; }
        public string Icono { get; set; }
        public string Descripcion { get; set; }
        public string Sub_Descripcion { get; set; } = null;

        public int _cantidad { get; set; }

        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                _cantidad = value;
                OnPropertyChanged();

            }
        }
    }
}
