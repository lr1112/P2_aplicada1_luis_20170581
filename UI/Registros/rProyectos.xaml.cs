using segundo_parcial.BLL;
using segundo_parcial.Entidades;
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
using static segundo_parcial.Entidades.Proyectos;

namespace segundo_parcial.UI.Registros
{
    /// <summary>
    /// Interaction logic for rProyectos.xaml
    /// </summary>
    public partial class rProyectos : Window
    {
        Proyectos proyecto;
        List<TareaDetalle> detalle;
        public rProyectos()
        {
            InitializeComponent();

            TareasComboBox.ItemsSource = TiposTareaBLL.ObtenerLista(t => true);
            TareasComboBox.SelectedValuePath = "TipoId";
            TareasComboBox.DisplayMemberPath = "Descripcion";

            detalle = new List<TareaDetalle>();

            proyecto = new Proyectos();
            DataContext = null;
            DataContext = proyecto;
        }
      

        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AgregarBoton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void RemoverBoton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void NuevoBoton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void GuardarBoton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {
            
        }
       

        public class TareaDetalle
        {
            public int ProyectosDetalleId { get; set; }
            public int ProyectoId { get; set; }
            public int TipoId { get; set; }
            public string Tipo { get; set; }
            public string Requerimiento { get; set; }
            public double Tiempo { get; set; }


            public TareaDetalle(ProyectosDetalle detalle)
            {
                ProyectosDetalleId = detalle.ProyectosDetalleId;
                ProyectoId = detalle.ProyectoId;
                TipoId = detalle.TipoId;
                Tipo = TiposTareaBLL.Buscar(TipoId).Descripcion;
                Requerimiento = detalle.Requerimiento;
                Tiempo = detalle.Tiempo;
            }
        }


    }
}
