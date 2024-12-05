using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

namespace var11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Entrance_Click(object sender, RoutedEventArgs e)
        {
            List<string> users = new List<string>() { "Admin", "Client" };
            List<string> password = new List<string>() { "12345", "11111" };
            if ((Name.Text == users[0]) && (Password.Text == password[0]))
            {
                administrator Administrator = new administrator();
                Administrator.Show();
                this.Close();
            }
            else if ((Name.Text == users[1]) && (Password.Text == password[1]))
            {
                klient Klient = new klient();
                Klient.Show();
                this.Close();
            }
            else MessageBox.Show("Неправильный логин или пароль");
        }
    }
}
