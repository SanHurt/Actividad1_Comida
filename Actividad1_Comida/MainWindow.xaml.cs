
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace Actividad1_Comida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Plato> listaPlatos;
        public MainWindow()
        {
            InitializeComponent();
            listaPlatos = Plato.GetSamples(@"E:/\DAM\2DAM\DINT\UT5\Imagenes\");
            listBox.DataContext = listaPlatos; 
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            stackpanel.DataContext = listBox.SelectedItem;
            /*comboBox.ItemsSource = listBox.SelectedItem;*/
        }
    }
}
