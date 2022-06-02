using EasyParking.Views.Estacionamientos.MisEstacionamientos;
using EasyParking.Views.Generales;
using EasyParking.Views.PerfilDeNegocio.Tarifas.Tarifa;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EasyParking.Views.Estacionamientos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Estacionamiento : ContentPage
    {
        List<byte[]> BytesLista = new List<byte[]>();
        byte[] ImagenArray = null;

        Stream STREAM;
        List<ImageSource> ImageSourceLista = new List<ImageSource>();

        public ImageSource EstacionamientoImagen { get; set; }
        public Estacionamiento()
        {
            InitializeComponent();
            frameTarifaAuto.IsVisible = frameTarifaCamioneta.IsVisible = frameTarifaMoto.IsVisible = false;
            entryCantidadAuto.IsEnabled = entryCantidadCamioneta.IsEnabled = entryCantidadMoto.IsEnabled = false;


            List<Horario> PeriodosLunes = new List<Horario>();

            Horario h = new Horario
            {
                Periodo = "8:00 - 12:30"
            };
            Horario h2 = new Horario
            {
                Periodo = "14:00 - 12:30"
            };
            Horario h3 = new Horario
            {
                Periodo = "9:00 - 12:30"
            };
            PeriodosLunes.Add(h);
            PeriodosLunes.Add(h2);
            PeriodosLunes.Add(h3);

            lwHorariosLunes.ItemsSource = new string[]
                                            {
                                              h.Periodo,
                                              h2.Periodo,
                                                h2.Periodo,
                                              h3.Periodo
                                            };

            lwHorariosMartes.ItemsSource = new string[]
                                           {
                                              h3.Periodo
                                           };

            lwHorariosMiercoles.ItemsSource = new string[]
                                           {
                                              h.Periodo,
                                              h3.Periodo
                                           };

            lwHorariosSabado.ItemsSource = new string[]
                                           {
                                              h.Periodo,
                                              h3.Periodo
                                           };


        }

        public class Horario
        {
            public string Periodo { get; set; }
        }

        private void ConvertSourceToBytes()
        {

            //  SignaturePadSource = signaturePad.ImageSource;

            if (Imagen.Source != null)
            {
                StreamImageSource streamImageSource = (StreamImageSource)Imagen.Source;


                System.Threading.CancellationToken cancellationToken =
                System.Threading.CancellationToken.None;
                Task<Stream> task = streamImageSource.Stream(cancellationToken);
                Stream stream = task.Result;

                // store bytes
                // byte[] bytes = new byte[stream.Length];
                //stream.Read(bytes, 0, bytes.Length);

                byte[] imageArray = null;
                byte[] imageArray2 = null;

                using (MemoryStream memory = new MemoryStream())
                {

                    stream.CopyTo(memory);
                    imageArray = memory.ToArray();
                }

                EstacionamientoImagen = ImageSource.FromStream(() =>
                {
                    return new MemoryStream(imageArray);
                });

                imageArray2 = imageArray;

                // FotosLista.Add(imageArray2);
            }
        }




        private void comboBoxTipoDeEstado_SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        {

        }

        private void comboBoxTipoDeLugar_SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        {

        }

        /// /////// No se usan /// ///////
        private async void btnAutoTarifa_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupTarifa("Auto"));
        }

        private async void btnCamionetaTarifa_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupTarifa("Camioneta"));
        }

        private async void btnMotoTarifa_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupTarifa("Moto"));
        }
        /// /////// //////// /// ///////

        private void checkBoxAuto_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((bool)checkBoxAuto.IsChecked)
            {
                frameTarifaAuto.IsVisible = entryCantidadAuto.IsEnabled = true;
            }
            else
            {
                frameTarifaAuto.IsVisible = entryCantidadAuto.IsEnabled = false;

            }
        }

        private void checkBoxCamioneta_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((bool)checkBoxCamioneta.IsChecked)
            {
                frameTarifaCamioneta.IsVisible = entryCantidadCamioneta.IsEnabled = true;
            }
            else
            {
                frameTarifaCamioneta.IsVisible = entryCantidadCamioneta.IsEnabled = false;
            }
        }

        private void checkBoxMoto_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if ((bool)checkBoxMoto.IsChecked)
            {
                frameTarifaMoto.IsVisible = entryCantidadMoto.IsEnabled = true;
            }
            else
            {
                frameTarifaMoto.IsVisible = entryCantidadMoto.IsEnabled = false;
            }
        }

        private async void btnEditarHorarioLunes_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PushAsync(new PopupRangoHorario());

        }

        private async void btnTomarFoto_Clicked(object sender, EventArgs e)
        {
            var result = await MediaPicker.CapturePhotoAsync();

            if (result != null)
            {
                STREAM = await result.OpenReadAsync();
                Imagen.Source = ImageSource.FromStream(() => STREAM);
                imagenEmpty.IsVisible = labelimagenEmpty.IsVisible = false;
                ImageSource IM = Imagen.Source;
                ConvertSourceToBytes4(result, IM);
                //STREAM.Dispose();
            }



        }

        private async void ConvertSourceToBytes4(FileResult result, ImageSource IM)
        {


            if (Imagen.Source != null)
            {

                StreamImageSource streamImageSource = (StreamImageSource)ImageSource.FromStream(() => STREAM);
                System.Threading.CancellationToken cancellationToken = System.Threading.CancellationToken.None;
                Task<Stream> task = streamImageSource.Stream(cancellationToken);
                Stream stream = task.Result;

                STREAM = await result.OpenReadAsync();
                Imagen.Source = ImageSource.FromStream(() => STREAM);
                imagenEmpty.IsVisible = labelimagenEmpty.IsVisible = false;

                byte[] imageArray = null;

                using (MemoryStream memory = new MemoryStream())
                {
                    stream.CopyTo(memory);
                    imageArray = memory.ToArray();
                }

                ImagenArray = imageArray;
            }
        }

        private async void ConvertSourceToBytes4(MediaFile result, ImageSource IM)
        {


            if (Imagen.Source != null)
            {

                StreamImageSource streamImageSource = (StreamImageSource)IM;
                System.Threading.CancellationToken cancellationToken = System.Threading.CancellationToken.None;
                Task<Stream> task = streamImageSource.Stream(cancellationToken);
                Stream stream = task.Result;

                var stream2 = result.GetStream();
                Imagen.Source = ImageSource.FromStream(() => stream2);
                imagenEmpty.IsVisible = labelimagenEmpty.IsVisible = false;

                byte[] imageArray = null;

                using (MemoryStream memory = new MemoryStream())
                {
                    stream.CopyTo(memory);
                    imageArray = memory.ToArray();
                }

                ImagenArray = imageArray;
            }
        }

        private async void btnSeleccionarFoto_Clicked(object sender, EventArgs e)
        {

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Seleccion de fotos NO permitida", "Se require permisos para seleccionar fotos.", "Entendido");
                return;
            }

            var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.MaxWidthHeight,

            });


            if (file == null)
            {
                return;

            }
            else
            {
                imagenEmpty.IsVisible = labelimagenEmpty.IsVisible = false;

            }

            Imagen.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });

            ConvertSourceToBytes4(file, Imagen.Source);

            //file.Dispose();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            Modelo.Estacionamiento estacionamiento = new Modelo.Estacionamiento();

            estacionamiento.Imagen = ImagenArray;

            estacionamiento.Nombre = entryNombre.Text;

            estacionamiento.Direccion = entryDireccion.Text;

            estacionamiento.TipoDeLugar = comboBoxTipoDeLugar.Text;

            if ((bool)checkBoxAuto.IsChecked && Convert.ToInt32(entryCantidadAuto.Value) != 0)  // AUTO DESDE ACA
            {
                Modelo.DataVehiculoAlojado dataVehiculo = new Modelo.DataVehiculoAlojado();
                dataVehiculo.TipoDeVehiculo = "Auto";
                dataVehiculo.CapacidadDeAlojamiento = Convert.ToInt32(entryCantidadAuto.Value);
                dataVehiculo.Tarifa_Hora = Convert.ToInt32(entryAuto_TarifaHora.Text);
                dataVehiculo.Tarifa_Dia = Convert.ToInt32(entryAuto_TarifaDia.Text);
                dataVehiculo.Tarifa_Semana = Convert.ToInt32(entryAuto_TarifaSemana.Text);
                dataVehiculo.Tarifa_Mes = Convert.ToInt32(entryAuto_TarifaMes.Text);

                estacionamiento.Vehiculos.Add(dataVehiculo); // HASTA ACA
            }


            if ((bool)checkBoxCamioneta.IsChecked && Convert.ToInt32(entryCantidadCamioneta.Value) != 0)  // CAMIONETA DESDE ACA
            {
                Modelo.DataVehiculoAlojado dataVehiculo = new Modelo.DataVehiculoAlojado();
                dataVehiculo.TipoDeVehiculo = "Camioneta";
                dataVehiculo.CapacidadDeAlojamiento = Convert.ToInt32(entryCantidadCamioneta.Value);
                dataVehiculo.Tarifa_Hora = Convert.ToInt32(entryCamioneta_TarifaHora.Text);
                dataVehiculo.Tarifa_Dia = Convert.ToInt32(entryCamioneta_TarifaDia.Text);
                dataVehiculo.Tarifa_Semana = Convert.ToInt32(entryCamioneta_TarifaSemana.Text);
                dataVehiculo.Tarifa_Mes = Convert.ToInt32(entryCamioneta_TarifaMes.Text);

                estacionamiento.Vehiculos.Add(dataVehiculo); // HASTA ACA
            }


            if ((bool)checkBoxMoto.IsChecked && Convert.ToInt32(entryCantidadMoto.Value) != 0) // MOTO DESDE ACA
            {
                Modelo.DataVehiculoAlojado dataVehiculo = new Modelo.DataVehiculoAlojado();
                dataVehiculo.TipoDeVehiculo = "Moto";
                dataVehiculo.CapacidadDeAlojamiento = Convert.ToInt32(entryCantidadMoto.Value);
                dataVehiculo.Tarifa_Hora = Convert.ToInt32(entryMoto_TarifaHora.Text);
                dataVehiculo.Tarifa_Dia = Convert.ToInt32(entryMoto_TarifaDia.Text);
                dataVehiculo.Tarifa_Semana = Convert.ToInt32(entryMoto_TarifaSemana.Text);
                dataVehiculo.Tarifa_Mes = Convert.ToInt32(entryMoto_TarifaMes.Text);

                estacionamiento.Vehiculos.Add(dataVehiculo); // HASTA ACA
            }

            estacionamiento.MontoReserva = Convert.ToDecimal(entryMontoReserva.Text);

        }
    }
}