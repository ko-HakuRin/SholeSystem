using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Shoole
{
    public partial class TaskListWindow : Window
    {
        public TaskListWindow()
        {
            InitializeComponent();
        }

        public TaskListWindow(IList<Models.Task> tasks)
        {
            InitializeComponent();


            ListTask.ItemsSource = tasks;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ListTask.SelectedIndex != -1)
            {
                new TaskWindow((Models.Task)ListTask.SelectedValue).ShowDialog();
            }
        }
    }
}
