using System;
using System.Collections.Generic;
using System.IO;
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

namespace InsightForge.Playground.Pages
{
    /// <summary>
    /// DisplayInfo.xaml 的交互逻辑
    /// </summary>
    public partial class DisplayInfo : Page
    {
        public DisplayInfo()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await webView.EnsureCoreWebView2Async(null);
            //webView.CoreWebView2.Navigate("https://www.example.com"); // 替换为您的测试页面 URL
            //string htmlFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Web\\display-info.html");
            //webView.CoreWebView2.Navigate($"file:///{htmlFilePath.Replace("\\", "/")}");
            LoadHtmlFile();
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (webView.CoreWebView2 != null)
            {
                LoadHtmlFile();
            }
        }

        private void LoadHtmlFile()
        {
            string htmlFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), $"Web\\display-info.html?nocache={DateTime.Now.ToString("yyyyMMddHHmmssfff")}");
            webView.CoreWebView2.Navigate($"file:///{htmlFilePath.Replace("\\", "/")}");
        }
    }
}
