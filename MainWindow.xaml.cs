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

namespace u1_03_quinnComputer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonNextMboard_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/large/CNET-AS0-300806629.jpg"));
            CPU.Source = bi;
            buttonNextMboard.Visibility = Visibility.Hidden;
            btnPreviousCPU.Visibility = Visibility.Visible;
            btnNextRam.Visibility = Visibility.Visible;
            cpulinkblock.Visibility = Visibility.Hidden;
        }

        private void btnPreviousCPU_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("http://cdn.idealo.com/folder/Product/4810/7/4810790/s1_produktbild_mid/intel-core-i7-6700k.jpg"));
            CPU.Source = bi;
            btnPreviousCPU.Visibility = Visibility.Hidden;
            btnNextRam.Visibility = Visibility.Hidden;
            buttonNextMboard.Visibility = Visibility.Visible;
            cpulinkblock.Visibility = Visibility.Visible;
        }
        private void btnNextRam_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/71CoFPtQ3QL._SX425_.jpg"));
            CPU.Source = bi;
            btnNextRam.Visibility = Visibility.Hidden;
            btnPreviousCPU.Visibility = Visibility.Hidden;
            btnNextStorage.Visibility = Visibility.Visible;
            btnPreviousMboard.Visibility = Visibility.Visible;
        }
        private void btnPreviousMboard_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/large/CNET-AS0-300806629.jpg"));
            CPU.Source = bi;
            btnNextRam.Visibility = Visibility.Visible;
            btnPreviousCPU.Visibility = Visibility.Visible;
            btnNextStorage.Visibility = Visibility.Hidden;
            btnPreviousMboard.Visibility = Visibility.Hidden;
        }

        private void btnPreviousRam_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/71CoFPtQ3QL._SX425_.jpg"));
            CPU.Source = bi;
            btnNextStorage.Visibility = Visibility.Visible;
            btnPreviousMboard.Visibility = Visibility.Visible;
            btnPreviousRam.Visibility = Visibility.Hidden;
            btnNextCase.Visibility = Visibility.Hidden;
        }

        private void btnNextStorage_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri(""))
        }

        private void btnPreviousStorage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNextCase_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPreviousCase_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNextPower_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Link1_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=9877540&amp;CatId=11862");
            
        }
    }
}
