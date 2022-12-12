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

namespace FutbolClub.Administracion
{
    /// <summary>
    /// Aqui va la interacción para ListadoEquipos.xaml
    /// </summary>
    public partial class ListadoEquipos : Window
    {
        public ListadoEquipos()
        {
            InitializeComponent();
            dgListadoEquipos.ItemsSource = Clases.EquipoCollection.equipos;
            dgListadoEquipos.CanUserAddRows= false;
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            int index = dgListadoEquipos.SelectedIndex;
            Administracion.ActualizarEquipo actualizar = new(index);

            actualizar.ShowDialog();


        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            int index = dgListadoEquipos.SelectedIndex;
            Clases.EquipoCollection.equipos.RemoveAt(index);
            dgListadoEquipos.Items.Refresh();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            dgListadoEquipos.Items.Refresh();
        }
    }
}
