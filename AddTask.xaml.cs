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

namespace PZ10_4
{
    /// <summary>
    /// Логика взаимодействия для AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void AddTask_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            string new_task = NewTask.Text;
            if (new_task is null)
            {
                MessageBox.Show("Введите задачу");
            }
            main.TaskList.Items.Add(new_task);
            this.Close();
            
        }
    }
}
