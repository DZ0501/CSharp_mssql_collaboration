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

namespace Base
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dating_app_databaseEntities db = new dating_app_databaseEntities();
            var men = from m in db.mezczyznas
                      select m;

            foreach (var item in men)
            {
                Console.WriteLine(item.Imie);
                Console.WriteLine(item.Nazwisko);
            }

            this.grid_men.ItemsSource = men.ToList();
        }
    }
}
