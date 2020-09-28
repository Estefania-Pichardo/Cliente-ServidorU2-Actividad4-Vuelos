using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Threading;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace Unidad2Actividad4Vuelos
{
    public class ClienteVuelos
    {
        HttpClient cliente;

        public delegate void Movimiento();
        public event Movimiento AlHaberMovimiento;

        public ClienteVuelos()
        {
            cliente = new HttpClient();
            cliente.BaseAddress=new Uri("http://vuelos.itesrc.net/");
        }
        public ObservableCollection<DatosVuelo> Model { get; set; }
        public async void Get()
        {         
            var response = await cliente.GetAsync("http://vuelos.itesrc.net/Tablero");

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                Model = JsonConvert.DeserializeObject<ObservableCollection<DatosVuelo>>(jsonString);
                AlHaberMovimiento?.Invoke();
            }
            
        }

        public async void Agregar(DatosVuelo vuelo)
        {

            var json = JsonConvert.SerializeObject(vuelo);
            var result = await cliente.PostAsync("/Tablero", new StringContent(json, Encoding.UTF8, "application/json"));

            result.EnsureSuccessStatusCode();
            AlHaberMovimiento?.Invoke();
        }

        public async void Editar(DatosVuelo vuelo)
        {

            var json = JsonConvert.SerializeObject(vuelo);
            var result = await cliente.PutAsync("/Tablero", new StringContent(json, Encoding.UTF8, "application/json"));

            result.EnsureSuccessStatusCode();
            AlHaberMovimiento?.Invoke();
        }

        public async void Eliminar(DatosVuelo vuelo)
        {
            var json = JsonConvert.SerializeObject(vuelo);

            HttpRequestMessage message = new HttpRequestMessage(HttpMethod.Delete, "/Tablero");
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await cliente.SendAsync(message);
            result.EnsureSuccessStatusCode();
            AlHaberMovimiento?.Invoke();
        }

    }
}
