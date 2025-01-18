using System.IO;
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
using InsightForge.Playground.Pages;

namespace InsightForge.Playground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public MainWindow()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception ex)
            {
                int i = 0;
            }
        }

        private void DisplayInfoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // 使用 Frame 进行导航
            Main.Navigate(new DisplayInfo());
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // 退出应用
            Application.Current.Shutdown();
        }

        private void ShowControlsDemoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new ControlsDemo());
        }

        private void WellboreMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new Wellbore());
        }
    }
}