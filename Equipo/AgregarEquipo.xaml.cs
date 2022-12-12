using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Aqui va la interacción para AgregarEquipo.xaml
    /// </summary>
    public partial class AgregarEquipo : Window
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombreequipo = txtNombreEquipo.Text;
            int cantidadjugadores = Convert.ToInt32(txtCantidadJugadores.Text);
            string nombredt = txtNombreDT.Text;
            string tipoequipo = cmbTipoEquipo.Text;
            string capitanequipo = txtCapitan.Text;
            bool tienesub21 = (chkSub21.IsChecked.Value)? true: false;

            Clases.Equipo p = new (nombreequipo,cantidadjugadores,nombredt,tipoequipo,capitanequipo,tienesub21);

            Clases.EquipoCollection.equipos.Add(p);

            this.Close();
        }

        private static Regex s_regex = new Regex("[^0-9]+");
        private void CheckTextInput(object sender, TextCompositionEventArgs e) 
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
