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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Unidad2Actividad4Vuelos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClienteVuelos cliente = new ClienteVuelos();
        DatosVuelo vuelo = new DatosVuelo();
        private int time = 0;
        private DispatcherTimer Timer;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vuelo;
            cliente.Get();
            cliente.AlHaberMovimiento += Cliente_AlHaberMovimiento;


            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 5);
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(time>=0)
            {
                cliente.Get();
                time++;
            }
        }

        private void Cliente_AlHaberMovimiento()
        {
            dtgListaVuelos.ItemsSource = cliente.Model.OrderBy(x=>x.Hora);
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cliente.Agregar(vuelo);
                

                txtDestino.Clear();
                txtHora.Clear();
                txtVuelo.Clear();
                cmbEstado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (dtgListaVuelos.SelectedIndex != -1)
            {
                Editar editar = new Editar();
                DatosVuelo vueloEditar = dtgListaVuelos.SelectedItem as DatosVuelo;
                editar.DataContext = vueloEditar;
                editar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un vuelo para editar", "Atecion", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(dtgListaVuelos.SelectedIndex!=-1)
            {
                try
                {
                    DatosVuelo vueloEliminar = new DatosVuelo();
                    vueloEliminar = dtgListaVuelos.SelectedItem as DatosVuelo;
                    if(MessageBox.Show($"Estas seguro que deseas eliminar el vuelo {vueloEliminar.Vuelo}?"
                        ,"Atencion", MessageBoxButton.OKCancel,MessageBoxImage.Warning)==MessageBoxResult.OK)
                    {
                        cliente.Eliminar(vueloEliminar);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un vuelo para Eliminar","Atecion", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbEstado.Items.Add("A Tiempo");
            cmbEstado.Items.Add("Abordando");
            cmbEstado.Items.Add("Cancelado");
            cmbEstado.Items.Add("Retrasado");
        }


    }
}
