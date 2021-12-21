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
using System.Windows.Threading;

namespace stromecek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 500);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int cislo = random.Next(0, 3);
            if (cislo == 0)
            {
                B01.Source = (ImageSource)FindResource("zlata");
                B02.Source = (ImageSource)FindResource("zlata");
                B03.Source = (ImageSource)FindResource("zlata");
                B04.Source = (ImageSource)FindResource("zlata");
                B05.Source = (ImageSource)FindResource("zlata");
                B06.Source = (ImageSource)FindResource("zlata");

            }
            else if (cislo == 1)
            {
                B01.Source = (ImageSource)FindResource("bila");
                B02.Source = (ImageSource)FindResource("bila");
                B03.Source = (ImageSource)FindResource("bila");
                B04.Source = (ImageSource)FindResource("bila");
                B05.Source = (ImageSource)FindResource("bila");
                B06.Source = (ImageSource)FindResource("bila");

            }
            else if (cislo == 2)
            {
                B01.Source = (ImageSource)FindResource("cervena");
                B02.Source = (ImageSource)FindResource("cervena");
                B03.Source = (ImageSource)FindResource("cervena");
                B04.Source = (ImageSource)FindResource("cervena");
                B05.Source = (ImageSource)FindResource("cervena");
                B06.Source = (ImageSource)FindResource("cervena");
            }
        }
    }
}
