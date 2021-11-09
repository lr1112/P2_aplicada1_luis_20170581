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

namespace segundo_parcial.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cProyectos.xaml
    /// </summary>
    public partial class cProyectos : Window
    {
        public cProyectos()
        {
            InitializeComponent();
        }

        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            var lista = new List<Proyectos>();
            string criterio = CriterioTextBox.Text;

            if (criterio.Length != 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = ProyectosBLL.ObtenerLista(p => p.ProyectoId == Utilities.ToInt(criterio));
                        break;
                    case 1:
                        lista = ProyectosBLL.ObtenerLista(p => p.Descripcion.ToLower().Contains(criterio.ToLower()));
                        break;
                    case 2:
                        lista = ProyectosBLL.ObtenerLista(p => p.TiempoTotal == Utilities.ToDouble(criterio));
                        break;

                }
            }
            else
            {
                lista = ProyectosBLL.ObtenerLista(p => true);
            }

            if (lista.Count == 0)
            {
                MessageBox.Show("No se encontró ningún proyecto", "Consulta de proyectos");
            }

            ProyectosDataGrid.ItemsSource = null;
            ProyectosDataGrid.ItemsSource = lista;
        }
    }
    
}
