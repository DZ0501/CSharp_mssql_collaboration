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
    /// Logika interakcji dla klasy window_men_del.xaml
    /// </summary>
    public partial class window_men_del : Window
    {
        public window_men_del()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dating_app_databaseEntities db = new dating_app_databaseEntities();

            byte text_id;

            try
            {
                text_id = Convert.ToByte(txtID.Text);

            }
            catch
            {
                MessageBox.Show("Empty ID! Value changed to 0 by default.");
                txtID.Text = "0";
            }

            byte text_id_fixed = Convert.ToByte(txtID.Text);


            var r = from m in db.mezczyznas
                    where m.ID == text_id_fixed
                    select m;

            mezczyzna mezczyznaObject = r.SingleOrDefault();

            if (mezczyznaObject != null)
            {
                db.mezczyznas.Remove(mezczyznaObject);
                db.SaveChanges();

                MessageBox.Show("Done!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            window_men_decision window_men_Decision = new window_men_decision();
            window_men_Decision.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
