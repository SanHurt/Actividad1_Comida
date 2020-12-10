using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Actividad1_Comida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Plato> listaPlatos;
        List<string> listaComboBox;
        public MainWindow()
        {
            InitializeComponent();
            listaPlatos = Plato.GetSamples(@"E:/\DAM\2DAM\DINT\UT5\Imagenes\");
            listBox.DataContext = listaPlatos;
            listaComboBox = new List<string>() { "Mexicana", "Americana", "China" };
            comboBox.DataContext = listaComboBox;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stackpanel.DataContext = listBox.SelectedItem;
        }
    }
}
