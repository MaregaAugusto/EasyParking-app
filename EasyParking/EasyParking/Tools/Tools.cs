using EasyParking.Interfaces;
using EasyParking.Modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace EasyParking.Tools
{
    public static class Tools
    {
        public static List<Estacionamiento> GetEstacionamientosMock()
        {
            Estacionamiento estacionamiento = new Estacionamiento();

            estacionamiento.Imagen = null;// // IMAGEN DEL LUGAR

            estacionamiento.Nombre = "";// // NOMBRE DEL LUGAR

            estacionamiento.Direccion = "";// // DIRECCION DEL LUGAR

            estacionamiento.TipoDeLugar = "";// // TIPO DEL LUGAR

            // LOS RANGO HORARIOS YA SE CARGARON ANTES EN EL EVENTO --> btnEditarHorario_Clicked

            //********** TEMA VEHICULOS ACEPTADOS Y SUS TARIFAS **********//

            DataVehiculoAlojado dataVehiculo = new DataVehiculoAlojado();
            dataVehiculo.TipoDeVehiculo = "Auto";
            dataVehiculo.CapacidadDeAlojamiento = 0;
            dataVehiculo.Tarifa_Hora = 0;
            dataVehiculo.Tarifa_Dia = 0;
            dataVehiculo.Tarifa_Semana = 0;
            dataVehiculo.Tarifa_Mes = 0;

            estacionamiento.Vehiculos.Add(dataVehiculo); // HASTA ACA


            DataVehiculoAlojado dataVehiculo1 = new DataVehiculoAlojado();
            dataVehiculo1.TipoDeVehiculo = "Moto";
            dataVehiculo1.CapacidadDeAlojamiento = 0;
            dataVehiculo1.Tarifa_Hora = 0;
            dataVehiculo1.Tarifa_Dia = 0;
            dataVehiculo1.Tarifa_Semana = 0;
            dataVehiculo1.Tarifa_Mes = 0;

            estacionamiento.Vehiculos.Add(dataVehiculo1); // HASTA ACA


            DataVehiculoAlojado dataVehiculo2 = new DataVehiculoAlojado();
            dataVehiculo2.TipoDeVehiculo = "Moto";
            dataVehiculo2.CapacidadDeAlojamiento = 0;
            dataVehiculo2.Tarifa_Hora = 0;
            dataVehiculo2.Tarifa_Dia = 0;
            dataVehiculo2.Tarifa_Semana = 0;
            dataVehiculo2.Tarifa_Mes = 0;

            estacionamiento.Vehiculos.Add(dataVehiculo2); // HASTA ACA


            estacionamiento.MontoReserva = 0; // MONTO DE LA RESERVA


            App.Estacionamientos.Add(estacionamiento);

            return App.Estacionamientos;
        }


        public static List<string> TruncarLosDecimales(List<string> Lista)
        {
            return Lista;
        }

        public static decimal TruncarLosDecimales(string numero)
        {

            if (numero.Contains("."))
            {
                numero = numero.Replace(".", ",");
            }

            int indice = 0;

            char[] array = numero.ToCharArray();
            string NumeroTruncados = "";

            while (array[indice] != ',')
            {
                NumeroTruncados = NumeroTruncados + array[indice];
                indice++;
            }

            NumeroTruncados = NumeroTruncados + array[indice];
            indice++;
            NumeroTruncados = NumeroTruncados + array[indice];
            indice++;
            NumeroTruncados = NumeroTruncados + array[indice];

            decimal redondeo = System.Math.Round(Convert.ToDecimal(NumeroTruncados), 2);

            return redondeo;
        }

        public static string ExceptionMessage(Exception e)
        {
            string message = e.Message;
            while (e.InnerException != null)
            {
                e = e.InnerException;
                message = message + " -*- " + e.Message;
            };


            return message;

        }

        public static string TraduceError(Exception ex)
        {
            string errorMessage = "";

            if (ex.Message.ToUpper().Contains("FAILED TO CONNECT TO"))
            {
                errorMessage = "Se ha perdido la conexion a Internet";
            }
            else if (ex.Message.ToUpper().Contains("A TASK WAS CANCELED"))
            {
                errorMessage = "El Servidor parece no estar disponible ... \n \n Intenta mas tarde.";
            }
            else if (ex.Message.ToUpper().Contains("INTENTO DE LOGIN NO VALIDO"))
            {
                errorMessage = "Email o Contraseña NO VALIDOS";
            }
            else if (ex.Message.ToUpper().Contains("THE OPERATION WAS CANCELED"))
            {
                errorMessage = "El Servidor parece no estar disponible ... \n \n Intenta mas tarde.";
            }
            else if (ex.Message.ToUpper().Contains("SOCKET CLOSED"))
            {
                errorMessage = "El Servidor parece no estar disponible ... \n \n Intenta mas tarde.";
            }
            else
            {
                errorMessage = ex.Message;
            }

            return errorMessage;

        }


        public static string QuitarGuionBajoAEnums(string value)
        {
            return value.Replace("_", " ");
        }

        public static string AgregarGuionBajoAEnums(string value)
        {
            return value.Replace(" ", "_");
        }

        public static string PrimerLetraMayusculaRestoMinuscula(string value)
        {
            return (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(value.ToLower()));
        }



        public static void Messages(string Mensaje)
        {
            DependencyService.Get<IMessage>().Longtime(Mensaje);
        }
    }




}
