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
    /// Logika interakcji dla klasy window_start.xaml
    /// </summary>
    public partial class window_start : Window
    {
        public window_start()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window_start_decision window_Start = new window_start_decision();
            window_Start.Show();
            this.Close();
        }
    }
}
