using EasyParking.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using static EasyParking.Views.Estacionamientos.MisEstacionamientos.PopupRangoHorario;

namespace EasyParking.Modelo
{
    public class Estacionamiento
    {
        public Estacionamiento()
        {
            for (int i = 0; i < DiasConHorarios.Length; i++)
            {
                DiasConHorarios[i] = new Dia();
            }
        }
        public int PersonaId { get; set; } // se asocia al dueño 
        public byte[] Imagen { get; set; } // podria ser lista // imagen del lugar
        public string Nombre { get; set; } // nombre del lugar
        public string Direccion { get; set; } // Direccion del lugar
        public Dia[] DiasConHorarios { get; set; } = new Dia[7]; // horarios en los que opera
        public string TipoDeLugar { get; set; } // descripcion del lugar - galpon, aire libre etc..
        public List<DataVehiculoAlojado> Vehiculos { get; set; } = new List<DataVehiculoAlojado>();// vehiculos aceptados
        public decimal MontoReserva { get; set; } // precio de la reserva si es que tiene 

    }

    public class TipoDeLugar // Tablas -- podrian haber mas de los inicalmente planteados
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } // terreno aire abierto - etc..
    }

    public class TipoDeVehiculo // Tablas -- podrian haber mas de los inicalmente planteados
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } // auto - moto - camioneta
    }



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
