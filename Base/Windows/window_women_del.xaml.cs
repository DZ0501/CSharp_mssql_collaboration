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
    /// Logika interakcji dla klasy window_women_del.xaml
    /// </summary>
    public partial class window_women_del : Window
    {
        public window_women_del()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            window_women_decision window_Women_Decision = new window_women_decision();
            window_Women_Decision.Show();
            this.Close();
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


            var r = from w in db.kobietas
                    where w.ID == text_id_fixed
                    select w;

            kobieta kobietaObject = r.SingleOrDefault();

            if (kobietaObject != null)
            {
                db.kobietas.Remove(kobietaObject);
                db.SaveChanges();

                MessageBox.Show("Done!");
            }
        }
    }
}
