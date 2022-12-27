using Prog12Petrakov.Classes;
using Prog12Petrakov.Windows;
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

namespace Prog12Petrakov
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

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var Log = DBconnection.Connect.Users.Where(z => z.Login == TxtLogin.Text && z.Password == TxtPass.Password).FirstOrDefault();
            if(Log != null)
            {
                if(Log.Id_Role == 2)
                {
                    ZvonochekWindow win = new ZvonochekWindow();
                    win.Show();
                    this.Close();
                }
                if (Log.Id_Role == 2)
                {
                    ZvonochekWindow win = new ZvonochekWindow();
                    win.Show();
                    this.Close();
                }
                if (Log.Id_Role == 2)
                {
                    ZvonochekWindow win = new ZvonochekWindow();
                    win.Show();
                    this.Close();
                }
                if (Log.Id_Role == 2)
                {
                    ZvonochekWindow win = new ZvonochekWindow();
                    win.Show();
                    this.Close();
                }
            }
            else { MessageBox.Show("Такого пользователя не существует"); } 
        }
    }
}
