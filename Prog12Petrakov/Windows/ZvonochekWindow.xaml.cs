using Prog12Petrakov.Classes;
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

namespace Prog12Petrakov.Windows
{
    /// <summary>
    /// Логика взаимодействия для ZvonochekWindow.xaml
    /// </summary>
    public partial class ZvonochekWindow : Window
    {
        public ZvonochekWindow()
        {
            InitializeComponent();
            Refresh();
        }

        private void BtnShowTel_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            ListTelePhones.ItemsSource = null;
            ListTelePhones.ItemsSource = DBconnection.Connect.Telephones.Where(z => z.IsAvailable == true).ToList();
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow win = new AddClientWindow();
            win.Show();
            this.Close();
        }
    }
}
