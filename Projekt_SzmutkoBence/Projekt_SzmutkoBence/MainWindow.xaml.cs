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

namespace Projekt_SzmutkoBence
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

        private void ujHozzaad_Click(object sender, RoutedEventArgs e)
        {            
            CheckBox check = new CheckBox();
            check.Checked += new RoutedEventHandler(checkbox_Checked);
            check.Unchecked += new RoutedEventHandler(checkbox1_Unchecked_1);
            check.Content = feldatSzoveg.Text;
            feladatokListaja.Items.Add(check);
            feldatSzoveg.Clear();
            
        }
        private void feladatokListaja_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CheckBox kijelolKiirasa = (CheckBox)feladatokListaja.SelectedItem;
            if (kijelolKiirasa == null)
            {
                return;
            }
            feldatSzoveg.Text = kijelolKiirasa.Content.ToString();
        }
        private void kijeloltTorlese_Click(object sender, RoutedEventArgs e)
        {
            CheckBox nev2 = (CheckBox)feladatokListaja.SelectedItem;
            feladatokListaja.Items.Remove(nev2);
            toroltElemek.Items.Add(nev2);
            feladatokListaja.Items.Refresh();
            toroltElemek.Items.Refresh();
        }
        private void checkbox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox nev = (CheckBox)sender;
            nev.FontStyle = FontStyles.Italic;
            nev.Foreground = Brushes.Gray;
        }


        private void checkbox1_Unchecked_1(object sender, RoutedEventArgs e)
        {
            CheckBox nev = (CheckBox)sender;
            nev.FontStyle = FontStyles.Normal;
            nev.Foreground = Brushes.Black;
        }
        private void kijeloltVisszaAll_Click(object sender, RoutedEventArgs e)
        {
            CheckBox kijeloltVissza = (CheckBox)toroltElemek.SelectedItem;
            toroltElemek.Items.Remove(kijeloltVissza);
            feladatokListaja.Items.Add(kijeloltVissza);
        }

        private void kijeloltVegTorlese_Click(object sender, RoutedEventArgs e)
        {
            CheckBox torles = (CheckBox)toroltElemek.SelectedItem;
            toroltElemek.Items.Remove(torles);
        }

        private void kijeloltModositas_Click(object sender, RoutedEventArgs e)
        {
            CheckBox modosit = (CheckBox)feladatokListaja.SelectedItem;
            modosit.Content = feldatSzoveg.Text;
        }
    }
}
