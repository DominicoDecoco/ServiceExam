using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Feedback.xaml
    /// </summary>
    public partial class Feedback : Window
    {
        public readonly DataBase.ExamPerfectEntities entities;
        public ObservableCollection<DataBase.TypeService> TypeServices { get; set; }
        public ObservableCollection<DataBase.Feedback> Feedbacks { get; set; }
        public Feedback()
        {

            InitializeComponent();
            
            DataContext = this;
        }

        private void ClickSaveComm(object sender, RoutedEventArgs e)
        {

        }
    }
}
