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

namespace Akademia_C
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        

        public Window2()
        {
            Levels Name1 = new Levels();
            Name1.Read();
            InitializeComponent();
            sLabel1.Content = Name1.strRecord1;
            sLabel2.Content = Name1.strRecord2;
            sLabel3.Content = Name1.strRecord3;
            sLabel4.Content = Name1.strRecord4;
            sLabel5.Content = Name1.strRecord5;
            nLabel1.Content = Name1.nRecord1;
            nLabel2.Content = Name1.nRecord2;
            nLabel3.Content = Name1.nRecord3;
            nLabel4.Content = Name1.nRecord4;
            nLabel5.Content = Name1.nRecord5;
        }
        

        public string Tekst = "Krzysiek";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (new MainWindow()).Show();
            this.Close();
        }
        
    }
}
