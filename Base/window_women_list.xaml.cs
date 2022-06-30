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

namespace Base
{
    /// <summary>
    /// Logika interakcji dla klasy window_women_list.xaml
    /// </summary>
    public partial class window_women_list : Window
    {
        public window_women_list()
        {
            InitializeComponent();

            dating_app_databaseEntities db = new dating_app_databaseEntities();
            var women = from w in db.kobietas
                        select new
                        {
                            Imię = w.Imie,
                            Nazwisko = w.Nazwisko,
                            Wiek = w.Wiek,
                            Miejscowość = w.Miejscowosc
                      };

            this.grid_women.ItemsSource = women.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
