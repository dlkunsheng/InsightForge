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

namespace InsightForge.Playground.Pages
{
    /// <summary>
    /// Wellbore.xaml 的交互逻辑
    /// </summary>
    public partial class Wellbore : Page
    {
        public Wellbore()
        {
            InitializeComponent();
        }

        private void Shape_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Shape shape)
            {
                shape.Opacity = 0.7; // 悬停时透明度变化
                shape.ToolTip = $"You hovered over a {shape.GetType().Name}";
            }
        }

        private void Shape_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender is Shape shape)
            {
                shape.Opacity = 1.0; // 恢复默认透明度
            }
        }

        private void Shape_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Shape shape)
            {
                MessageBox.Show($"You clicked on a {shape.GetType().Name}!");
            }
        }
    }
}
