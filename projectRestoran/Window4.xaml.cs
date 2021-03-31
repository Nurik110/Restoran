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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Restoran restaurant4 { get; set; }
        List<string> elems = new List<string>()
        {
            "LIGHT - 2000",
            "Jack-Daniels(виски) - 1500",
            "Remy Martin Vs(коньяк) - 2200",
            "Bailey(ликер) - 1400"
        };
        public Window4()
        {
            InitializeComponent(); 
            restaurant4 = new Restoran
            {
                RestaurantName = "Bellagio Restaurant & Club",
                RestaurantCategory = "Итальянская, Европейская",
                dishesDay = "салат",
                rating = "4.5",
                workingHours = "с 11:00 до 00:00"
            };
            StackTwo.DataContext = restaurant4;
            img1.Source = new BitmapImage(new Uri("img/Bellagio Restaurant & Club.jpg", UriKind.Relative));
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
