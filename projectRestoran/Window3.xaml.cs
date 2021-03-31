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

namespace projectRestoran
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Restoran restaurant3 { get; set; }
        List<string> elems = new List<string>()
        {
            "LIGHT - 2000",
            "Jack-Daniels(виски) - 1500",
            "Remy Martin Vs(коньяк) - 2200",
            "Bailey(ликер) - 1400"
        };
        public Window3()
        {
            InitializeComponent();
            restaurant3 = new Restoran
            {
                RestaurantName = "Vista",
                RestaurantCategory = "Итальянская, Международная, Турецкая",
                dishesDay = "салат",
                rating = "4.0",
                workingHours = "с 12:00 до 03:00"
            };
            StackTwo.DataContext = restaurant3;
            img1.Source = new BitmapImage(new Uri("img/Vista.jpg", UriKind.Relative));
        }
        private void res2_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stackpanel = new StackPanel();

            for (int i = 0; i < elems.Count; i++)
            {
                Label labelText1 = new Label();
                labelText1.Content = elems[i];
                stackpanel.Children.Add(labelText1);
            }
            res2.Content = stackpanel;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainW = new MainWindow();
            mainW.Show();
            this.Close();
        }
    
    }
}
