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
    /// Logika interakcji dla klasy window_men_decision.xaml
    /// </summary>
    public partial class window_men_decision : Window
    {
        public window_men_decision()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window_men_list window_men_List = new window_men_list();
            window_men_List.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            window_men_del window_men_Del = new window_men_del();
            window_men_Del.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            window_men_add window_men_Add = new window_men_add();
            window_men_Add.Show();
            this.Close();
        }
    }
}
