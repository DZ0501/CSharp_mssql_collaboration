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

namespace Base.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy window_men_list.xaml
    /// </summary>
    public partial class window_men_list : Window
    {
        public window_men_list()
        {
            InitializeComponent();

            dating_app_databaseEntities db = new dating_app_databaseEntities();
            var men = from m in db.mezczyznas
                        select new
                        {
                            ID = m.ID,
                            Imię = m.Imie,
                            Nazwisko = m.Nazwisko,
                            Wiek = m.Wiek,
                            Miejscowość = m.Miejscowosc
                        };

            this.grid_men.ItemsSource = men.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            window_men_decision window_men_Decision = new window_men_decision();
            window_men_Decision.Show();
            this.Close();
        }
    }
}
