using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Unidad2Actividad4Vuelos
{
    /// <summary>
    /// Lógica de interacción para Editar.xaml
    /// </summary>
    public partial class Editar : Window
    {
        public Editar()
        {
            InitializeComponent();

        }
        ClienteVuelos cliente = new ClienteVuelos();

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            DatosVuelo vuelo = this.DataContext as DatosVuelo;
            try
            {
                cliente.Editar(vuelo);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbEstado.Items.Add("A Tiempo");
            cmbEstado.Items.Add("Abordando");
            cmbEstado.Items.Add("Cancelado");
            cmbEstado.Items.Add("Retrasado");
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
