using System.Windows;

namespace Shoole
{
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();

            ShowedAnswer.IsChecked = Argv.ShowedAnswer;
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            Argv.ShowedAnswer = ShowedAnswer.IsChecked ?? false ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
