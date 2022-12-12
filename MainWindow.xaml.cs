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

namespace FutbolClub
{
    /// <summary>
    /// Vistas que interactuan con la logica for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnAcercade_Click(object sender, RoutedEventArgs e)
        {
            Acercade.acercade acercade = new();
            acercade.ShowDialog();
        }

        private void btnAgrearEquipo_Click(object sender, RoutedEventArgs e)
        {
            Administracion.AgregarEquipo agregar = new();
            agregar.ShowDialog();
        }

        private void btnListarEquipo_Click(object sender, RoutedEventArgs e)
        {
            Administracion.ListadoEquipos listado = new();
            listado.ShowDialog();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
