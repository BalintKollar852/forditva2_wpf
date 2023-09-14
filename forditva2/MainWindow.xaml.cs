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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;


namespace forditva2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool fordide = true;
        public MainWindow()
        {
            InitializeComponent();
            Szoveg_Box.Items.Add("merev");
            Szoveg_Box.Items.Add("török");
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Szöveg
            if (Szavankent.IsChecked == true)
            {

                string anyad = Szoveg_Input.Text.ToString();
                string[] anyad_splitted = anyad.Split(' ');
                string csabakurva = String.Empty;
                foreach (var item in anyad_splitted)
                {
                    char[] csabikurvageci = item.ToCharArray();
                    Array.Reverse(csabikurvageci);
                    csabakurva += new string(csabikurvageci) + " ";
                }
                csabakurva.Trim();
                Szoveg_label.Content = csabakurva;


            }
            else
            {
                char[] SzovegArray = Szoveg_Input.Text.ToString().ToCharArray();
                Array.Reverse(SzovegArray);
                Szoveg_label.Content = new string(SzovegArray);
            }
            //Szó
            char[] SzoArray = Szoveg_Box.SelectedItem.ToString().ToCharArray();
            Array.Reverse(SzoArray); 
            Szo_Label.Content = new string(SzoArray);
            //numerikus forditas
            //NumberTextBox Szam_Recpiok
            Szam_Recpiok.Content = Convert.ToString(1 / Convert.ToDouble(NumberTextBox.Text));
            //kep forditas
            Kep.RenderTransformOrigin = new Point(0.5, 0.5);
            if (fordide) { kepforrotate.ScaleY = -1; fordide = false; }
            else if (!fordide) { kepforrotate.ScaleY = 1; fordide = true; }
        }
    }
}

