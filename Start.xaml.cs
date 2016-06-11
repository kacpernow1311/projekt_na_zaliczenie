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


namespace projekt_na_zaliczenie
{
    /// <summary>
    /// Interaction logic for Start.xaml
    /// </summary>

    public partial class Start : Window
    {

        public ObservableCollection<Panstwa_miasta> listawpisow;
        public Start()
        {
            
            InitializeComponent();
            listawpisow = new ObservableCollection<Panstwa_miasta>();

            Panstwa_miasta wpis = new Panstwa_miasta();
            wpis.Panstwo = "Argentyna";
            wpis.Miasto = "Amsterdam";
            wpis.Rzecz = "Abażur";
            wpis.Roślina = "Arbuz";
            wpis.Zawód = "Aptekarz";
            wpis.Zwierze = "Aligator";
            wpis.Imie = "Anna";
            wpis.suma = 0;
            listawpisow.Add(wpis);
            this.ListView1.ItemsSource = listawpisow;

        }
        int a=0;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(ImieTextBox.Text))
                {
                    MessageBox.Show("Musisz uzupełnić wszystkie pola");
                }
            }
            catch
            {
               
            }
            Panstwa_miasta wpis = new Panstwa_miasta();
            wpis.Panstwo = this.PanstwoTextBox.Text;
            wpis.Miasto = this.MiastoTextBox.Text;
            wpis.Rzecz = this.RzeczTextBox.Text;
            wpis.Roślina = this.RoślinaTextBox.Text;
            wpis.Zawód = this.ZawódTextBox.Text;
            wpis.Zwierze = this.ZwierzeTextBox.Text;
            wpis.Imie = this.ImieTextBox.Text;
            wpis.pkt1 = int.Parse(this.pkt1TextBox.Text);
            wpis.pkt2 = int.Parse(this.pkt2TextBox.Text);
            wpis.pkt3 = int.Parse(this.pkt3TextBox.Text);
            wpis.pkt4 = int.Parse(this.pkt4TextBox.Text);
            wpis.pkt5 = int.Parse(this.pkt5TextBox.Text);
            wpis.pkt6 = int.Parse(this.pkt6TextBox.Text);
            wpis.pkt7 = int.Parse(this.pkt7TextBox.Text);
            wpis.suma = wpis.pkt1 + wpis.pkt2 + wpis.pkt3 + wpis.pkt4 + wpis.pkt5 + wpis.pkt6 + wpis.pkt7;
            a += wpis.suma;
            listawpisow.Add(wpis);
            PanstwoTextBox.Text = String.Empty;
            MiastoTextBox.Text = String.Empty;
            RzeczTextBox.Text = String.Empty;
            RoślinaTextBox.Text = String.Empty;
            ZawódTextBox.Text = String.Empty;
            ZwierzeTextBox.Text = String.Empty;
            ImieTextBox.Text = String.Empty;
            pkt1TextBox.Text = String.Empty;
            pkt2TextBox.Text = String.Empty;
            pkt3TextBox.Text = String.Empty;
            pkt4TextBox.Text = String.Empty;
            pkt5TextBox.Text = String.Empty;
            pkt6TextBox.Text = String.Empty;
            pkt7TextBox.Text = String.Empty;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string[] letters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "W", "Z" };
            Random r = new Random();
            int num = r.Next(0, 20);
            string wylosowana = letters[num];
            label.Content = wylosowana;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GRATULACJE !!!\nZdobyłeś "+a+" punktów.\nMam nadzieję, że gra sprawiła Ci dużo przyjemności :)");
            Environment.Exit(0);
        }
    }
}
