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

namespace var11
{
    /// <summary>
    /// Логика взаимодействия для klient.xaml
    /// </summary>
    public partial class klient : Window
    {
        public klient()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mainwindow = new MainWindow();
            Mainwindow.Show();
            this.Close();
        }

        private void buyAdvertisement_Click(object sender, RoutedEventArgs e)
        {
            buyAdvertisement BuyAdvertisement = new buyAdvertisement();
            BuyAdvertisement.Show();
            this.Close();
        }

        private void historyK_Click(object sender, RoutedEventArgs e)
        {
            historyK HistoryK = new historyK();
            HistoryK.Show();
            this.Close();
        }
    }
}
