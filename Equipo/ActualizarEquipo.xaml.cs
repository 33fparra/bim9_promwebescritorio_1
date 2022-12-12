using FutbolClub.Administracion.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Aqui va la lógica ActualizarEquipo.xaml
    /// </summary>
    public partial class ActualizarEquipo : Window
    {
        public ActualizarEquipo(int index)
        {
            InitializeComponent();

            txtNombreEquipo_2.Text = EquipoCollection.equipos[index].NombreEquipo;
            txtCantidadJugadores_2.Text = Convert.ToString(EquipoCollection.equipos[index].CantidadJugadores);
            txtNombreDT_2.Text = EquipoCollection.equipos[index].NombreDT;
            cmbTipoEquipo_2.Text = EquipoCollection.equipos[index].TipoEquipo;
            txtCapitan_2.Text = EquipoCollection.equipos[index].CapitanEquipo;
            chkSub21_2.IsChecked = EquipoCollection.equipos[index].TieneSub21;

            Clases.EquipoCollection.equipos.RemoveAt(index);
        }


        private void btn_actualizarEquipo_Click(object sender, RoutedEventArgs e)
        {

            string nombreequipo = txtNombreEquipo_2.Text;
            int cantidadjugadores = Convert.ToInt32(txtCantidadJugadores_2.Text);
            string nombredt = txtNombreDT_2.Text;
            string tipoequipo = cmbTipoEquipo_2.Text;
            string capitanequipo = txtCapitan_2.Text;
            bool tienesub21 = (chkSub21_2.IsChecked.Value) ? true : false;

           Clases.Equipo p = new(nombreequipo, cantidadjugadores, nombredt, tipoequipo, capitanequipo, tienesub21);

            Clases.EquipoCollection.equipos.Add(p);

            this.Close();

        }
    }
}
