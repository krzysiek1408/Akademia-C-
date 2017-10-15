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
        int Space = 0;
        int[] Rolled = new int[10];
        string[] strCountries = new string[10];
        public Window3()
        {
            InitializeComponent();

            ImgPoland.Visibility = Visibility.Collapsed;    //0
            ImgChiny.Visibility = Visibility.Collapsed;     //1
            ImgFrancja.Visibility = Visibility.Collapsed;   //2
            ImgGrecja.Visibility = Visibility.Collapsed;    //3
            ImgHiszpania.Visibility = Visibility.Collapsed; //4
            ImgJaponia.Visibility = Visibility.Collapsed;   //5
            ImgNiemcy.Visibility = Visibility.Collapsed;    //6
            ImgUSA.Visibility = Visibility.Collapsed;       //7
            ImgWlochy.Visibility = Visibility.Collapsed;    //8
            ImgRosja.Visibility = Visibility.Collapsed;     //9

            
            string strCountry;
            
                strCountries[0] = "Polska";
                strCountries[1] = "Chiny";
                strCountries[2] = "Francja";
                strCountries[3] = "Grecja";
                strCountries[4] = "Hiszpania";
                strCountries[5] = "Japonia";
                strCountries[6] = "Niemcy";
                strCountries[7] = "USA";
                strCountries[8] = "Wlochy";
                strCountries[9] = "Rosja";
            



            //Random_Flag Diced = new Random_Flag();
            int NumberOfFlags = 10;
            
            //Rolled = Diced.Randomize(10);
            //Rolled[0] = 7;
            //Rolled[1] = 3;

            Random rand = new Random();
            int n = 10;
            int nDice;
            int Condition;      // Warunek używany do sprawdzenia czy wylosowana wartość się nie powtarza
            int j;

            for (int i = 0; i < 10; i++)        // zerowanie tablicy z wynikami
            {
                Rolled[i] = 11;
            }

            for (int i = 0; i < 10; i++)
            {
                nDice = rand.Next(n);
                Condition = 0;
                for(int x=i; x<10; x++)
                {
                    if(Rolled[x]==nDice)
                    {
                        Condition = 1;
                        i--;
                    }
                }
                if (Condition == 0)
                { Rolled[i] = nDice; }

            }


            ////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////                  WYSWIETLANIE
            ////////////////////////////////////////////////////////////////////////////////////////////////
            void Show(int q, int x)
            {
                for (int i = q; i < q+x; i++)
                {
                    if (Rolled[i] == 0)
                    {
                        ImgPoland.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 1)
                    {
                        ImgChiny.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 2)
                    {
                        ImgFrancja.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 3)
                    {
                        ImgGrecja.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 4)
                    {
                        ImgHiszpania.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 5)
                    {
                        ImgJaponia.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 6)
                    {
                        ImgNiemcy.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 7)
                    {
                        ImgUSA.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 8)
                    {
                        ImgWlochy.Visibility = Visibility.Visible;
                    }
                    if (Rolled[i] == 9)
                    {
                        ImgRosja.Visibility = Visibility.Visible;
                    }
                }
            }




            
            Show(Space,1);
            Helpful StartingLabels = new Helpful();
            int[] Labels = new int[4];
            Labels = StartingLabels.Randomize(4, Rolled[0]);
            LabelA.Content = strCountries[Labels[0]];
            LabelB.Content = strCountries[Labels[1]];
            LabelC.Content = strCountries[Labels[2]];
            LabelD.Content = strCountries[Labels[3]];


        }
        void Show(int q, int x)
        {
            for (int i = q; i < q + x; i++)
            {
                if (Rolled[i] == 0)
                {
                    ImgPoland.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 1)
                {
                    ImgChiny.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 2)
                {
                    ImgFrancja.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 3)
                {
                    ImgGrecja.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 4)
                {
                    ImgHiszpania.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 5)
                {
                    ImgJaponia.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 6)
                {
                    ImgNiemcy.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 7)
                {
                    ImgUSA.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 8)
                {
                    ImgWlochy.Visibility = Visibility.Visible;
                }
                if (Rolled[i] == 9)
                {
                    ImgRosja.Visibility = Visibility.Visible;
                }
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
           (new MainWindow()).Show();
           this.Close();
        }


        

        


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ImgPoland.Visibility = Visibility.Collapsed;    //0
            ImgChiny.Visibility = Visibility.Collapsed;     //1
            ImgFrancja.Visibility = Visibility.Collapsed;   //2
            ImgGrecja.Visibility = Visibility.Collapsed;    //3
            ImgHiszpania.Visibility = Visibility.Collapsed; //4
            ImgJaponia.Visibility = Visibility.Collapsed;   //5
            ImgNiemcy.Visibility = Visibility.Collapsed;    //6
            ImgUSA.Visibility = Visibility.Collapsed;       //7
            ImgWlochy.Visibility = Visibility.Collapsed;    //8
            ImgRosja.Visibility = Visibility.Collapsed;     //9
            Space++;
            if(Space>9)
            {
                (new MainWindow()).Show();
                this.Close();
            }
            Show(Space, 1);
            Helpful StartingLabels = new Helpful();
            int[] Labels = new int[4];
            Labels = StartingLabels.Randomize(4, Rolled[0]);
            LabelA.Content = strCountries[Labels[0]];
            LabelB.Content = strCountries[Labels[1]];
            LabelC.Content = strCountries[Labels[2]];
            LabelD.Content = strCountries[Labels[3]];

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ImgPoland.Visibility = Visibility.Collapsed;    //0
            ImgChiny.Visibility = Visibility.Collapsed;     //1
            ImgFrancja.Visibility = Visibility.Collapsed;   //2
            ImgGrecja.Visibility = Visibility.Collapsed;    //3
            ImgHiszpania.Visibility = Visibility.Collapsed; //4
            ImgJaponia.Visibility = Visibility.Collapsed;   //5
            ImgNiemcy.Visibility = Visibility.Collapsed;    //6
            ImgUSA.Visibility = Visibility.Collapsed;       //7
            ImgWlochy.Visibility = Visibility.Collapsed;    //8
            ImgRosja.Visibility = Visibility.Collapsed;     //9
            Space++;
            if (Space > 9)
            {
                (new MainWindow()).Show();
                this.Close();
            }
            Show(Space, 1);
            Helpful StartingLabels = new Helpful();
            int[] Labels = new int[4];
            Labels = StartingLabels.Randomize(4, Rolled[0]);
            LabelA.Content = strCountries[Labels[0]];
            LabelB.Content = strCountries[Labels[1]];
            LabelC.Content = strCountries[Labels[2]];
            LabelD.Content = strCountries[Labels[3]];
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ImgPoland.Visibility = Visibility.Collapsed;    //0
            ImgChiny.Visibility = Visibility.Collapsed;     //1
            ImgFrancja.Visibility = Visibility.Collapsed;   //2
            ImgGrecja.Visibility = Visibility.Collapsed;    //3
            ImgHiszpania.Visibility = Visibility.Collapsed; //4
            ImgJaponia.Visibility = Visibility.Collapsed;   //5
            ImgNiemcy.Visibility = Visibility.Collapsed;    //6
            ImgUSA.Visibility = Visibility.Collapsed;       //7
            ImgWlochy.Visibility = Visibility.Collapsed;    //8
            ImgRosja.Visibility = Visibility.Collapsed;     //9
            Space++;
            if (Space > 9)
            {
                (new MainWindow()).Show();
                this.Close();
            }
            Show(Space, 1);
            Helpful StartingLabels = new Helpful();
            int[] Labels = new int[4];
            Labels = StartingLabels.Randomize(4, Rolled[0]);
            LabelA.Content = strCountries[Labels[0]];
            LabelB.Content = strCountries[Labels[1]];
            LabelC.Content = strCountries[Labels[2]];
            LabelD.Content = strCountries[Labels[3]];
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ImgPoland.Visibility = Visibility.Collapsed;    //0
            ImgChiny.Visibility = Visibility.Collapsed;     //1
            ImgFrancja.Visibility = Visibility.Collapsed;   //2
            ImgGrecja.Visibility = Visibility.Collapsed;    //3
            ImgHiszpania.Visibility = Visibility.Collapsed; //4
            ImgJaponia.Visibility = Visibility.Collapsed;   //5
            ImgNiemcy.Visibility = Visibility.Collapsed;    //6
            ImgUSA.Visibility = Visibility.Collapsed;       //7
            ImgWlochy.Visibility = Visibility.Collapsed;    //8
            ImgRosja.Visibility = Visibility.Collapsed;     //9`
            Space++;
            if (Space > 9)
            {
                (new MainWindow()).Show();
                this.Close();
            }
            Show(Space, 1);
            Helpful StartingLabels = new Helpful();
            int[] Labels = new int[4];
            Labels = StartingLabels.Randomize(4, Rolled[0]);
            LabelA.Content = strCountries[Labels[0]];
            LabelB.Content = strCountries[Labels[1]];
            LabelC.Content = strCountries[Labels[2]];
            LabelD.Content = strCountries[Labels[3]];
        }
    }
}
