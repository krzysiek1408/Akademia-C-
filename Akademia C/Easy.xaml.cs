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
using System.Timers;

namespace Akademia_C



{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        int TimeLeft = 90;
        public Window3()
        {
            InitializeComponent();

            ImgPoland.Visibility = Visibility.Collapsed;
            ImgChiny.Visibility = Visibility.Collapsed;
            ImgFrancja.Visibility = Visibility.Collapsed;
            ImgGrecja.Visibility = Visibility.Collapsed;
            ImgHiszpania.Visibility = Visibility.Collapsed;
            ImgJaponia.Visibility = Visibility.Collapsed;
            ImgNiemcy.Visibility = Visibility.Collapsed;
            ImgUSA.Visibility = Visibility.Collapsed;
            ImgWlochy.Visibility = Visibility.Collapsed;
            ImgRosja.Visibility = Visibility.Collapsed;


            //_timer = new Timer();
            // _timer. += new EventHandler(timer_Tick);
            //_timer.Interval = 1;
            //_timer.Start();

            /*Timer Timer1 = new Timer();
            //timeX.Interval = 1800000;
            //Timer1.Tick += new EventHandler(timeX_Tick);
            Timer1.Enabled = true;
            Timer1.Start();*/

            /////////////////////////////////////////////////////////////Environment.CurrentDirectory

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           (new MainWindow()).Show();
           this.Close();
        }
        /*void Timer1_Tick(object sender, EventArgs e)
        {
            TimeLeft--;
            TimeLabel.Content = TimeLeft;
        }*/
        

        private int _countDown = 30; // Seconds
        private Timer _timer;

        

       // void timer_Tick(object sender, EventArgs e)
       // {
           // TimeLeft--;
           // TimeLabel.Content = TimeLeft;
            //_countDown--;
            //if (_countDown < 1)
            //{
            //    _countDown = 30;
            //}
            //lblCountDown.Text = _countDown.ToString();
        //}



        









        /*///

        Timer Timer1 = new Timer();
        private void StartTimer()
        {
            //Timer1 = new System.Windows.Forms.Timer();
            Timer1.Interval = 1000;
            //Timer1.Tick += new EventHandler(t_Tick);
            Timer1.Enabled = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            TimeLabel.Content = TimeLeft-1;
            /*przebieg = trackBar1.Value;
            label1.Text = "przebieg auta: " + Math.Round(((przebieg_p + przebieg) / 30000), 1) + "km";
            przebieg_p = przebieg_p + przebieg;*/
    //}
        ///*/
    }
}
