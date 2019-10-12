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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfPictureChange
{
    /// <summary>
    /// PictureChangeUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class PictureChangeUserControl : UserControl
    {
        public PictureChangeUserControl()
        {
            InitializeComponent();
            IniPic();
        }

        private void IniPic()
        {
            List<PicClass> pic = new List<PicClass>()
            {
                new PicClass(){Image=string.Format(@"/img/diablo.jpg"),Site="1"},
                new PicClass(){Image=string.Format(@"/img/gallardo.jpg"),Site="2"},
                new PicClass(){Image=string.Format(@"/img/Murcielago.jpg"),Site="3"},
                new PicClass(){Image=string.Format(@"/img/Reventon.jpg"),Site="4"},
            };
            this.listBoxPic.ItemsSource = pic;
        }

        DispatcherTimer timer;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(2000);
            timer.Tick += new EventHandler(timer_Tick);
            listBoxPic.SelectedIndex = 0;
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (listBoxPic.Items.Count > 0)
            {

                if (listBoxPic.SelectedIndex == listBoxPic.Items.Count - 1)
                {
                    listBoxPic.SelectedIndex = 0;
                }
                else
                {
                    listBoxPic.SelectedIndex += 1;
                }
            }
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
