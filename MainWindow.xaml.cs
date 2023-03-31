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
        ObservableCollection<string> fintasks;
        public MainWindow()
        {
            InitializeComponent();
            fintasks = new ObservableCollection<string>();
            finTaskList.ItemsSource = fintasks;
            tasks = new ObservableCollection<string> { "Сделать домашнее задание", "Купить цветы маме", "Придумать идею для приложения" };
            taskList.ItemsSource = tasks;
        }

        
        private void enterTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string addtask = enterTaskText.Text;
            tasks.Add(addtask);
            enterTaskText.Clear();
           
        }

        private void deleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if(finTaskList.SelectedIndex!=-1)
            {
                fintasks.RemoveAt(finTaskList.SelectedIndex);

            }
            
        }

        private void taskList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string promejutochnaya = taskList.SelectedItem.ToString();
            tasks.RemoveAt(taskList.SelectedIndex);
            fintasks.Add(promejutochnaya);

        }

      
        
        
    }
}
