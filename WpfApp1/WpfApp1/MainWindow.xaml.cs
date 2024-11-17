using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Opacity = 0.5;
            MessageBox.Show("Witaj, świecie!");
            btnStart.Opacity = 1.0;

            btnStart.Visibility = Visibility.Hidden;
            MessageBox.Show("Witaj ponownie, świecie!");
            btnStart.Visibility = Visibility.Visible;
        }

        private void btnTime_MouseEnter(object sender, MouseEventArgs e)
        {
            DateTime data = DateTime.Now;
            btnTime.Content = data.ToString("T");
        }

        private void btnTime_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTime.Content = "Czas";
        }

        private void btnActivateStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.IsEnabled = true;
        }
    }
}
