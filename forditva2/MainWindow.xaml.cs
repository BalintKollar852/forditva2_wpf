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
using static System.Net.Mime.MediaTypeNames;

namespace forditva2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Szoveg_Box.Items.Add("merev");
            Szoveg_Box.Items.Add("török");
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
            //kep forditas

        }
    }
}

