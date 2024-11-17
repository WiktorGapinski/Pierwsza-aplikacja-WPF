using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfProgram_TakNie
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnYes_MouseEnter(object sender, RoutedEventArgs e)
        {
            var tmpMargin = btnYes.Margin;

            btnYes.Margin = btnNo.Margin;
            btnNo.Margin = tmpMargin;
        }
    }
}