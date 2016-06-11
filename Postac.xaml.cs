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
using System.Windows.Shapes;

namespace projekt_na_zaliczenie
{
    /// <summary>
    /// Interaction logic for Postac.xaml
    /// </summary>
    class WyborPostaci
    {
        public virtual void Zwierze(ref string gracz)
        {
            gracz = "Wybrałeś zwierze";
        }
    }
    class Malpka : WyborPostaci
    {
        public override void Zwierze(ref string gracz)
        {
            gracz = "Wybrałeś Małpkę";
        }
    }
    class Lew : WyborPostaci
    {
        public override void Zwierze(ref string gracz)
        {
            gracz = "Wybrałeś Lwa";
        }
    }
    class Rekin : WyborPostaci
    {
        public override void Zwierze(ref string gracz)
        {
            gracz = "Wybrałeś Rekina";
        }
    }
    public partial class Postac : Window
    {
        public Postac()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Start start = new Start();
            this.Close();
            start.Show();
        }

        public void button1_Click(object sender, RoutedEventArgs e)
        {
            string a="";
            WyborPostaci wybor1 = new Malpka();
            wybor1.Zwierze(ref a);
            label.Content = a;
        }

        public void button2_Click(object sender, RoutedEventArgs e)
        {
            string a="";
            WyborPostaci wybor1 = new Lew();
            wybor1.Zwierze(ref a);
            label.Content = a;
        }

        public void button3_Click(object sender, RoutedEventArgs e)
        {
            string a = "";
            WyborPostaci wybor1 = new Rekin();
            wybor1.Zwierze(ref a);
            label.Content = a;
        }
    }
}
