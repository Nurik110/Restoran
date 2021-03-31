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

namespace projectRestoran
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 a = new Window1();
            a.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 a = new Window2();
            a.Show();
            this.Close();

        }
        private void bnt3_Click(object sender, RoutedEventArgs e)
        {
            Window3 a = new Window3();
            a.Show();
            this.Close();
        }

        private void bnt4_Click(object sender, RoutedEventArgs e)
        {
            Window4 a = new Window4();
            a.Show();
            this.Close();
        }

        private void bnt5_Click(object sender, RoutedEventArgs e)
        {
            Window5 a = new Window5();
            a.Show();
            this.Close();
        }

        private void bnt6_Click(object sender, RoutedEventArgs e)
        {
            Window6 a = new Window6();
            a.Show();
            this.Close();
        }

        private void bnt7_Click(object sender, RoutedEventArgs e)
        {
            Window7 a = new Window7();
            a.Show();
            this.Close();
        }

        private void bnt8_Click(object sender, RoutedEventArgs e)
        {
            Window8 a = new Window8();
            a.Show();
            this.Close();
        }

        private void bnt9_Click(object sender, RoutedEventArgs e)
        {
            Window9 a = new Window9();
            a.Show();
            this.Close();
        }

        private void bnt10_Click(object sender, RoutedEventArgs e)
        {
            Window10 a = new Window10();
            a.Show();
            this.Close();
        }

        private void bnt11_Click(object sender, RoutedEventArgs e)
        {
            Window11 a = new Window11();
            a.Show();
            this.Close();
        }

        private void bnt12_Click(object sender, RoutedEventArgs e)
        {
            Window12 a = new Window12();
            a.Show();
            this.Close();
        }

        private void bnt13_Click(object sender, RoutedEventArgs e)
        {
            Window13 a = new Window13();
            a.Show();
            this.Close();
        }

        private void bnt14_Click(object sender, RoutedEventArgs e)
        {
            Window14 a = new Window14();
            a.Show();
            this.Close();
        }

        private void bnt15_Click(object sender, RoutedEventArgs e)
        {
            Window15 a = new Window15();
            a.Show();
            this.Close();
        }
    }
}
