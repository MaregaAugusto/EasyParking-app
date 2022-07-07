using System;
using System.Collections.Generic;
using System.Text;

namespace EasyParking.Modelo
{
    public class DataVehiculoAlojado
    {
        public string TipoDeVehiculo { get; set; }
        public int CapacidadDeAlojamiento { get; set; }
        public decimal Tarifa_Hora { get; set; }
        public decimal Tarifa_Dia { get; set; }
        public decimal Tarifa_Semana { get; set; }
        public decimal Tarifa_Mes { get; set; }
    }
}
