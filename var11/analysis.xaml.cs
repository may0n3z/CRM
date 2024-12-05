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
    /// Логика взаимодействия для analysis.xaml
    /// </summary>
    public partial class analysis : Window
    {
        public analysis()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            administrator Administrator = new administrator();
            Administrator.Show();
            this.Close();
        }
    }
}
