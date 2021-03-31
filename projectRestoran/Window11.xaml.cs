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
    /// Логика взаимодействия для Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        public Restoran restaurant1 { get; set; }
        List<string> elems = new List<string>()
        {
            "Grey Goase(водка) - 2000",
            "Jack-Daniels(виски) - 1500",
            "Remy Martin Vs(коньяк) - 2200",
            "Bailey(ликер) - 1400",
            "Мясное ассорти - 4900",
            "Перец падрон - 4000",
        };
        public Window11()
        {
            InitializeComponent();
            restaurant1 = new Restoran
            {
                RestaurantName = "Тай Ресторан",
                RestaurantCategory = "Азиатская, Японская, Тайская",
                dishesDay = "Водка",
                rating = "3.5",
                workingHours = "с 12:00 до 23:00"

            };

            StackOne.DataContext = restaurant1;
            img1.Source = new BitmapImage(new Uri("img/Тай Ресторан.jpg", UriKind.Relative));
        }

        private void res1_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stackpanel = new StackPanel();

            for (int i = 0; i < elems.Count; i++)
            {
                Label labelText1 = new Label();
                labelText1.Content = elems[i];
                stackpanel.Children.Add(labelText1);
            }
            res1.Content = stackpanel;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainW = new MainWindow();
            mainW.Show();
            this.Close();
        }
    }
}
