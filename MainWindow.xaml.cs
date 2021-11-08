using segundo_parcial.UI.Consultas;
using segundo_parcial.UI.Registros;
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

namespace segundo_parcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void rProyectosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            new rProyectos().Show();
        }

        public void cProyectosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            new cProyectos().Show();
        }
    }
}
