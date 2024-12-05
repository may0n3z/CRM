﻿using System;
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

namespace var11
{
    /// <summary>
    /// Логика взаимодействия для historyK.xaml
    /// </summary>
    public partial class historyK : Window
    {
        public historyK()
        {
            InitializeComponent();
            DGridOrder.ItemsSource = ISPEntities1.Instance().Orders.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            klient Klient = new klient();
            Klient.Show();
            this.Close();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                ISPEntities1.Instance().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridOrder.ItemsSource = ISPEntities1.Instance().Orders.ToList();
            }
        }
    }
}