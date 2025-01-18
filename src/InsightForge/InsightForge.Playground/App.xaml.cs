using System.Configuration;
using System.Data;
using System.Windows;

namespace InsightForge.Playground
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // 捕获非 UI 线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // 处理异常
            Exception ex = e.ExceptionObject as Exception;
            LogException(ex);
            ShowErrorDialog(ex);
        }

        private void LogException(Exception ex)
        {
            // 将异常记录到日志
            System.IO.File.AppendAllText("error.log", ex.ToString());
        }

        private void ShowErrorDialog(Exception ex)
        {
            MessageBox.Show("发生了一个非预期错误：" + ex.Message, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
