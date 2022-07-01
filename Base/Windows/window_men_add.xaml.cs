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
    /// Logika interakcji dla klasy window_men_add.xaml
    /// </summary>
    public partial class window_men_add : Window
    {
        public window_men_add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dating_app_databaseEntities db = new dating_app_databaseEntities();

            mezczyzna mezczyznaObject = new mezczyzna()
            {
                Imie = txtName.Text,
                Nazwisko = txtSurname.Text,
                Wiek = Convert.ToByte(txtAge.Text),
                Miejscowosc = txtDomicility.Text

            };

            db.mezczyznas.Add(mezczyznaObject);
            db.SaveChanges();

            MessageBox.Show("Done!");

            this.txtName.Text = "";
            this.txtSurname.Text = "";
            this.txtAge.Text = "";
            this.txtDomicility.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            window_men_decision window_men_Decision = new window_men_decision();
            window_men_Decision.Show();
            this.Close();
        }
    }
}
