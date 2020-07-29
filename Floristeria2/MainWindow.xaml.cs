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
using Floristeria2.Models;

namespace Floristeria2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //List<String> listaFlorist = new List<String>();
        Florist florist1;
        // GESTION EVENTOS FORMULARIO

        //Abrir ventana stock
        private void OpenWindowStock(object sender, RoutedEventArgs e)
        {
            WindowStock objWindowStock = new WindowStock(florist1);
            //this.Visibility = Visibility.Hidden;
            objWindowStock.Show();

        }

        //Crea objeto floristeria
        private void clickFloristeria(object sender, RoutedEventArgs e)
        {
            Florist floristeria = new Florist(nombreFloristeria);
            //listaFlorist.Add(floristeria.Nombre);
            florist1 = floristeria;
            MessageBox.Show(floristeria.Nombre);
            nombreFloristeria.Text = "";
        }

        //Crea objeto flor
        private void ClickFlower(object sender, RoutedEventArgs e)
        {
            Flower flor = new Flower(nombreFlor,colorFlor,precioFlor);
            florist1.ListaFlower.Add(flor);
            MessageBox.Show(flor.Nombre);
            nombreFlor.Text = "";
            colorFlor.Text = "";
            precioFlor.Text = "";
        }

        //Crea objeto arbol

        private void ClickTree(object sender, RoutedEventArgs e)
        {
            Tree arbol = new Tree(nombreArbol, alturaArbol, precioArbol);
            MessageBox.Show(arbol.Nombre);
            florist1.ListaTree.Add(arbol);           //se establlecen los campos en blanco una vez añadido para poder añadir más
            nombreArbol.Text = "";
            alturaArbol.Text = "";
            precioArbol.Text = "";
        }

        //Crea objeto Decoracion
        private void ClickDecor(object sender, RoutedEventArgs e)
        {
            Deco decoracion = new Deco(nombreDecoracion, materialDecoracion, precioDecoracion);
            MessageBox.Show(decoracion.Material);
            florist1.ListaDeco.Add(decoracion);
            nombreDecoracion.Text = "";
            precioDecoracion.Text = "";
        }
    }
}
