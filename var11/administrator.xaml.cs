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
    /// Логика взаимодействия для administrator.xaml
    /// </summary>
    public partial class administrator : Window
    {
        public administrator()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Mainwindow = new MainWindow();
            Mainwindow.Show();
            this.Close();
        }

        private void ManagementDB_Click(object sender, RoutedEventArgs e)
        {
            ManagementDB managementDB = new ManagementDB();
            managementDB.Show();
            this.Close();
        }

        private void historyA_Click(object sender, RoutedEventArgs e)
        {
            historyA HistoryA = new historyA();
            HistoryA.Show();
            this.Close();
        }

        private void Analysis_Click(object sender, RoutedEventArgs e)
        {
            analysis Analysis = new analysis();
            Analysis.Show();
            this.Close();
        }
    }
}
