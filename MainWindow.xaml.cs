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

        private void delete_task(object sender, RoutedEventArgs e)
        {
            DeleteTask();
        }

        private void TaskList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string task = TaskList.SelectedItem.ToString();
            tasks.RemoveAt(TaskList.SelectedIndex);
            complete_tasks.Add(task);
        }

        public void DeleteTask()
        {
            complete_tasks.RemoveAt(CompleteTasksList.SelectedIndex);
        }

        private void CompleteTasksList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DeleteTask();
        }

        private void newtaskTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                AddTask();
            }
        }

        public void AddTask()
        {
            tasks.Add(newtaskTextBox.Text);
            newtaskTextBox.Clear();
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            AddTask();
        }

        private void DelTask(object sender, KeyEventArgs e)
        {           
            if (e.Key == Key.Delete)
            {
                ListBox list = sender as ListBox;
                if (list.Name == "TaskList")
                {
                    string task = list.SelectedItem.ToString();
                    tasks.RemoveAt(TaskList.SelectedIndex);
                    complete_tasks.Add(task);
                }
                else
                {
                    complete_tasks.RemoveAt(CompleteTasksList.SelectedIndex);
                }
            }
        }
    }
}
