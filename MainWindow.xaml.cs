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
            LinkMboard.Visibility = Visibility.Visible;
            CpuNameCost.Visibility = Visibility.Hidden;
            MboardNameCost.Visibility = Visibility.Visible;
        }

        private void btnPreviousCPU_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("http://cdn.idealo.com/folder/Product/4810/7/4810790/s1_produktbild_mid/intel-core-i7-6700k.jpg"));
            CPU.Source = bi;
            btnPreviousCPU.Visibility = Visibility.Hidden;
            btnNextRam.Visibility = Visibility.Hidden;
            buttonNextMboard.Visibility = Visibility.Visible;
            cpulinkblock.Visibility = Visibility.Visible;
            LinkMboard.Visibility = Visibility.Hidden;
            CpuNameCost.Visibility = Visibility.Visible;
            MboardNameCost.Visibility = Visibility.Hidden;
        }
        private void btnNextRam_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/71CoFPtQ3QL._SX425_.jpg"));
            CPU.Source = bi;
            btnNextRam.Visibility = Visibility.Hidden;
            btnPreviousCPU.Visibility = Visibility.Hidden;
            btnNextStorage.Visibility = Visibility.Visible;
            btnPreviousMboard.Visibility = Visibility.Visible;
            LinkMboard.Visibility = Visibility.Hidden;
            LinkRam.Visibility = Visibility.Visible;
            MboardNameCost.Visibility = Visibility.Hidden;
            RamNameCost.Visibility = Visibility.Visible;
        }
        private void btnPreviousMboard_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/large/CNET-AS0-300806629.jpg"));
            CPU.Source = bi;
            btnNextRam.Visibility = Visibility.Visible;
            btnPreviousCPU.Visibility = Visibility.Visible;
            btnNextStorage.Visibility = Visibility.Hidden;
            btnPreviousMboard.Visibility = Visibility.Hidden;
            LinkMboard.Visibility = Visibility.Visible;
            LinkRam.Visibility = Visibility.Hidden;
            RamNameCost.Visibility = Visibility.Hidden;
            MboardNameCost.Visibility = Visibility.Visible;
        }

        private void btnPreviousRam_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/71CoFPtQ3QL._SX425_.jpg"));
            CPU.Source = bi;
            btnNextStorage.Visibility = Visibility.Visible;
            btnPreviousMboard.Visibility = Visibility.Visible;
            btnPreviousRam.Visibility = Visibility.Hidden;
            btnNextCase.Visibility = Visibility.Hidden;
            LinkRam.Visibility = Visibility.Visible;
            LinkStorage.Visibility = Visibility.Hidden;
            StorageNameCost.Visibility = Visibility.Hidden;
            RamNameCost.Visibility = Visibility.Visible;
        }

        private void btnNextStorage_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/51Ao-tIg7YL.jpg"));
            CPU.Source = bi;
            btnPreviousMboard.Visibility = Visibility.Hidden;
            btnNextStorage.Visibility = Visibility.Hidden;
            btnNextCase.Visibility = Visibility.Visible;
            btnPreviousRam.Visibility = Visibility.Visible;
            LinkStorage.Visibility = Visibility.Visible;
            LinkRam.Visibility = Visibility.Hidden;
            StorageNameCost.Visibility = Visibility.Visible;
            RamNameCost.Visibility = Visibility.Hidden;
        }

        private void btnPreviousStorage_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("https://images-na.ssl-images-amazon.com/images/I/51Ao-tIg7YL.jpg"));
            CPU.Source = bi;
            btnNextPower.Visibility = Visibility.Hidden;
            btnPreviousStorage.Visibility = Visibility.Hidden;
            btnNextCase.Visibility = Visibility.Visible;
            btnPreviousRam.Visibility = Visibility.Visible;
            LinkStorage.Visibility = Visibility.Visible;
            LinkCase.Visibility = Visibility.Hidden;
            StorageNameCost.Visibility = Visibility.Visible;
            CaseNameCost.Visibility = Visibility.Hidden;
        }

        private void btnNextCase_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/large/CNET-TML-300636288.jpg"));
            CPU.Source = bi;
            btnPreviousRam.Visibility = Visibility.Hidden;
            btnNextCase.Visibility = Visibility.Hidden;
            btnNextPower.Visibility = Visibility.Visible;
            btnPreviousStorage.Visibility = Visibility.Visible;
            LinkStorage.Visibility = Visibility.Hidden;
            LinkCase.Visibility = Visibility.Visible;
            CaseNameCost.Visibility = Visibility.Visible;
            StorageNameCost.Visibility = Visibility.Hidden;
        }

        private void btnPreviousCase_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("http://images.highspeedbackbone.net/skuimages/large/CNET-TML-300636288.jpg"));
            CPU.Source = bi;
            btnNextPower.Visibility = Visibility.Visible;
            btnPreviousStorage.Visibility = Visibility.Visible;
            btnPreviousCase.Visibility = Visibility.Hidden;
            LinkCase.Visibility = Visibility.Visible;
            LinkPower.Visibility = Visibility.Hidden;
            CaseNameCost.Visibility = Visibility.Visible;
            PowerNameCost.Visibility = Visibility.Hidden;
        }

        private void btnNextPower_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage(new Uri("https://static.bhphoto.com/images/images500x500/corsair_cp_9020082_na_rm750i_750w_80_plus_1447283724000_1165148.jpg"));
            CPU.Source = bi;
            btnNextPower.Visibility = Visibility.Hidden;
            btnPreviousCase.Visibility = Visibility.Visible;
            LinkPower.Visibility = Visibility.Visible;
            LinkCase.Visibility = Visibility.Hidden;
            CaseNameCost.Visibility = Visibility.Hidden;
            PowerNameCost.Visibility = Visibility.Visible;
            double number = (409.99 + 156.99 + 184.99 + 118.99 + 189.79 + 177.99);
            MessageBox.Show("The Computer costs $" + number.ToString());
        }

        private void Link1_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=9877540&amp;CatId=11862");

        }

        private void Link2_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=9942539&Sku=AS0-300806629");
        }

        private void Link3_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=2944384&Sku=YYI2-93473R");
        }

        private void Link4_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=3577731&Sku=YYI2-53173S");
        }

        private void Link5_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=8969367&Sku=TML-300636288");
        }

        private void Link6_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tigerdirect.ca/applications/SearchTools/item-details.asp?EdpNo=9953408&Sku=CQR-300807317");
        }
    }
}
