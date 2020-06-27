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

namespace d_motivator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            getWeekDay();
          

            

        }

        private void getWeekDay()
        {
            Random rnd = new Random();
            var weekNow = DateTime.Now.DayOfWeek;
            var baseFolder = Environment.CurrentDirectory + $@"\img\{weekNow}\" ;
            var countFiles = System.IO.Directory.GetFiles(baseFolder).Count();
            var fileName = baseFolder+ $@"{rnd.Next(1, countFiles)}.jpg";

            BitmapImage bm1 = new BitmapImage();
            bm1.BeginInit();
            bm1.UriSource = new Uri(fileName, UriKind.Relative);
            bm1.CacheOption = BitmapCacheOption.OnLoad;
            bm1.EndInit();
            Image1.Source = bm1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
