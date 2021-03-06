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
    /// Logika interakcji dla klasy window_women_decision.xaml
    /// </summary>
    public partial class window_women_decision : Window
    {
        public window_women_decision()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window_women_list window_women_List = new window_women_list();
            window_women_List.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            window_women_add window_women_Add = new window_women_add();
            window_women_Add.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            window_women_del window_women_Del = new window_women_del();
            window_women_Del.Show();
            this.Close();
        }
    }
}
