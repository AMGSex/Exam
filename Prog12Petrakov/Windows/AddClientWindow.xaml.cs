using Prog12Petrakov.Classes;
using Prog12Petrakov.DB;
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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            if(TxtName.Text != null)
            {
                Users Add = new Users()
                {
                    Name = TxtName.Text,
                    Id_Role = 5
                };
                DBconnection.Connect.Users.Add(Add);
                DBconnection.Connect.SaveChanges();
                MessageBox.Show("Добавлен новый клиент");
                this.Close();
            }
        }
    }
}
