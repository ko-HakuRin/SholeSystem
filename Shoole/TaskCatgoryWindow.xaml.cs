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

namespace Shoole
{
    public partial class TaskCatgoryWindow : Window
    {
        public TaskCatgoryWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var db = new DbEntities();

            var tasks = new List<Models.Task>();

            int index = 1;

            foreach (var item in db.Tasks)
            {
                if (item.Category_ID == 0)
                {
                    tasks.Add(new Models.Task(index, item.ID, item.Category_ID, item.Text, item.Answer, item.IsDone));
                    index++;
                }
            }

            new TaskListWindow(tasks).ShowDialog();
        }

        private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            var db = new DbEntities();

            var tasks = new List<Models.Task>();

            int index = 1;

            foreach (var item in db.Tasks)
            {
                if (item.Category_ID == 1)
                {
                    tasks.Add(new Models.Task(index, item.ID, item.Category_ID, item.Text, item.Answer, item.IsDone));
                    index++;
                }
            }

            new TaskListWindow(tasks).ShowDialog();
        }

        private void Border_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            var db = new DbEntities();

            var tasks = new List<Models.Task>();

            int index = 1;

            foreach (var item in db.Tasks)
            {
                if (item.Category_ID == 2)
                {
                    tasks.Add(new Models.Task(index, item.ID, item.Category_ID, item.Text, item.Answer, item.IsDone));
                    index++;
                }
            }

            new TaskListWindow(tasks).ShowDialog();
        }

        private void Border_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            var db = new DbEntities();

            var tasks = new List<Models.Task>();

            int index = 1;

            foreach (var item in db.Tasks)
            {
                if (item.Category_ID == 3)
                {
                    tasks.Add(new Models.Task(index, item.ID, item.Category_ID, item.Text, item.Answer, item.IsDone));
                    index++;
                }
            }

            new TaskListWindow(tasks).ShowDialog();
        }
    }
}
