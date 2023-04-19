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
using System.Collections.ObjectModel;

namespace PZ10_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
  
    {    
        ObservableCollection<string> tasks;
        ObservableCollection<string> complete_tasks;
        public MainWindow()
        {
            InitializeComponent();
            complete_tasks = new ObservableCollection<string>();
            CompleteTasksList.ItemsSource = complete_tasks;
            tasks = new ObservableCollection<string> { };
            TaskList.ItemsSource = tasks;
        } 

        private void Add_task(object sender, RoutedEventArgs e)
        {
            string nt = new_task.Text;
            tasks.Add(nt);
            new_task.Clear();
        }

        private void delete_task(object sender, RoutedEventArgs e)
        {
            complete_tasks.RemoveAt(CompleteTasksList.SelectedIndex);
        }

        private void Task_DC(object sender, MouseButtonEventArgs e)
        {
            string task = TaskList.SelectedItem.ToString();
            tasks.RemoveAt(TaskList.SelectedIndex);
            complete_tasks.Add(task);
        }
    }
}
