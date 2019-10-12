using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication1
{
    /// <summary>
    /// DialogWin.xaml 的交互逻辑
    /// </summary>
    public partial class DialogWin : Window
    {
        public DialogWin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // this.Close(); 
            /////timer定义
            tm.Tick += new EventHandler(tm_Tick);
            tm.Interval = TimeSpan.FromSeconds(0.2);
            tm.Start();
            Window1 w = new Window1();
            w.WindowStyle = System.Windows.WindowStyle.None;
            w.Show();
        }
        DispatcherTimer tm = new DispatcherTimer();
        void tm_Tick(object sender, EventArgs e)
        { this.Close(); }

        private void Canvas1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
