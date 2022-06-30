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
    /// Logika interakcji dla klasy window_women_add.xaml
    /// </summary>
    public partial class window_women_add : Window
    {
        public window_women_add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dating_app_databaseEntities db = new dating_app_databaseEntities();

            kobieta kobietaObject = new kobieta()
            {
                Imie = txtName.Text,
                Nazwisko = txtSurname.Text,
                Wiek = Convert.ToByte(txtAge.Text),
                Miejscowosc = txtDomicility.Text

            };

            db.kobietas.Add(kobietaObject);
            db.SaveChanges();

            MessageBox.Show("Done!");

            this.txtName.Text = "";
            this.txtSurname.Text = "";
            this.txtAge.Text = "";
            this.txtDomicility.Text = "";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            window_women_decision window_Women_Decision = new window_women_decision();
            window_Women_Decision.Show();
            this.Close();
        }
    }
}
