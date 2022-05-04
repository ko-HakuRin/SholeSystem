using System.Windows;

namespace Shoole
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;

            new TaskCatgoryWindow().ShowDialog();

            Visibility = Visibility.Visible;
        }

        private void SettingButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;

            new SettingWindow().ShowDialog();

            Visibility = Visibility.Visible;
        }
    }
}
