using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        enum Wybor
        {
            Regulamin,
            Stworz,
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Wybor value = Wybor.Stworz;
            if(value==Wybor.Stworz)
            {
                Postac postac = new Postac();
                this.Close();
                postac.Show();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Wybor value = Wybor.Regulamin;
            if (value == Wybor.Regulamin)
            {
                string msg = "Zasady gry w Państwa i Miasta są proste.\nKażdy gracz powinien napisać jak najwięcej wyrazów\nz zadanych kategorii przed upływem czasu.\nWszystkie wyrazy muszą zaczynać się na wylosowaną literę.\nZasady dotyczące punktowania:\n-15pkt masz wyraz, a w danej kategorii nikt nie znalazł wyrazu\n-10pkt masz wyraz z danej kategorii, który jest inny niż pozostałych graczy\n-5pkt masz wyraz, który jest taki sam jak, któregoś z graczy\nUwaga w każdym polu należy umieścić znak lub liczbę\njeżeli nie znasz wyrazu napisz samą literę\nMIŁEJ GRY !!!";
                MessageBox.Show(msg);
            }
        }
    }
}
