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
using WpfApp2.ViewModel;

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel();
        }
        
        /// <summary>
        /// 热点弹窗、搜索结果、搜索记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowHotSpot_TextChanged(object sender, TextChangedEventArgs e)
        {
            popHotSpot.IsOpen = false;
            popHotSpot.IsOpen = true;
        }
        /// <summary>
        /// 窗口最小化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinSizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 允许通过鼠标左键点击工作区拖动窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //this.Text = "2width:" + this.Width.ToString() + " height:" + this.Height.ToString();
            if (this.Width <= 250)
            {
                this.Width = 250;
            }

            if (this.Height <= 250)
            {
                this.Height = 250;
            }
        }

        /// <summary>
        /// 弹出设置菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowSettingsDialog_Click(object sender, RoutedEventArgs e)
        {
            popSettings.IsOpen = false;
            popSettings.IsOpen = true;
        }

        /// <summary>
        /// 获取微博数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    }
}
