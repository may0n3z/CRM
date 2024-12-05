using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Логика взаимодействия для buyAdvertisement.xaml
    /// </summary>
  
    public partial class buyAdvertisement : Window
    {
        private Order _currentOrder = new Order();
        private bool change = false;

        public buyAdvertisement()
        {
            Order selectedOrder = new Order();
            if (selectedOrder != null)
            {
                _currentOrder = selectedOrder;
                change = true;
            }
            DataContext = _currentOrder;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            klient Klient = new klient();
            Klient.Show();
            this.Close();
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            var listorderid = ISPEntities1.Instance().Orders.ToList();
            var idcount = listorderid.Count;

            if (string.IsNullOrWhiteSpace(_currentOrder.Period))
                errors.AppendLine("Укажите на какой период хотите взять рекламу");
            if (string.IsNullOrWhiteSpace(_currentOrder.Mail))
                errors.AppendLine("Укажите почту для связи");
            if (string.IsNullOrWhiteSpace(_currentOrder.NamePeople))
                errors.AppendLine("Укажите своё ФИО");

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            
            var order = ISPEntities1.Instance().Orders.Find(_currentOrder.id);

            if (errors.Length <= 0)
            {
                if
                    (change)
                {
                    idcount++;
                    if (_currentOrder.id == 0)
                        _currentOrder.id = idcount;
                    ISPEntities1.Instance().Orders.Add(_currentOrder);
                    
                }
                else
                {
                    order.Period = _currentOrder.Period;
                    order.Mail = _currentOrder.Mail;
                    order.NamePeople = _currentOrder.NamePeople;
                }
            }

            try
            {
                ISPEntities1.Instance().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            var time = int.Parse(Time.Text);
            var money = time * 1000;
            
        }        
    }
}
