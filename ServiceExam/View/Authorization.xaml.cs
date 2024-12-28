using ServiceExam.DataBase;
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

namespace ServiceExam.View
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        private readonly ExamPerfectEntities entities;
        private UserService user;
        public Authorization()
        {
            InitializeComponent();
            entities = new ExamPerfectEntities();
        }

        private void ClickAuto(object sender, RoutedEventArgs e)
        {
            string login = Login.Text.Trim();
            string password = Password.Text.Trim();
            user = entities.UserServices.Where(u => u.LoginUser == login && u.UserPassword == password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Неверные данные (логин/пароль)");
            }
            else
            {
                switch(user.RoleUser.NameRole)
                {
                    case "Администратор":
                        AdminMenu adminMenu = new AdminMenu(user);
                        adminMenu.Show();
                        Close();
                        break;
                case "Мастер":
                    
                    break;
                }
            }
        }

        private void ClickOpenFeedback(object sender, RoutedEventArgs e)
        {
            Feedback feedback = new Feedback();
            feedback.Show();
            Close();
        }
    }
}
