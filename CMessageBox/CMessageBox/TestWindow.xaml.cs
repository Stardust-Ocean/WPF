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

namespace Zmy.Wpf.CMessageBox
{
    /// <summary>
    /// TestWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!");
        }

        private void ButtonOKCancel_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!",CMessageBoxButton.OKCancel);
        }

        private void ButtonYesNo_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "YesNo",CMessageBoxButton.YesNO);
        }

        private void ButtonYesNoCancel_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "YesNo", CMessageBoxButton.YesNoCancel);
        }

        private void ButtonOK_OKDefault_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "ButtonOK_OKDefault_Click", CMessageBoxButton.OK, CMessageBoxImage.None, CMessageBoxDefaultButton.OK);

        }

        private void OKCancel_OKDefault_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "OKCancel_OKDefault_Click", CMessageBoxButton.OKCancel, CMessageBoxImage.None, CMessageBoxDefaultButton.OK);

        }

        private void OKCancel_CancelDefault_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "OKCancel_CancelDefault_Click", CMessageBoxButton.OKCancel, CMessageBoxImage.None, CMessageBoxDefaultButton.Cancel);

        }

        private void YesNo_YesDefault_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "YesNo_YesDefault_Click", CMessageBoxButton.YesNO, CMessageBoxImage.None, CMessageBoxDefaultButton.Yes);

        }

        private void YesNo_NoDefault_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "YesNo_NoDefault_Click", CMessageBoxButton.YesNO, CMessageBoxImage.None, CMessageBoxDefaultButton.No);

        }

        private void YesNoCancel_YesDefault_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "YesNoCancel_YesDefault_Click", CMessageBoxButton.YesNoCancel, CMessageBoxImage.None, CMessageBoxDefaultButton.Yes);

        }

        private void YesNoCancel_NoDefault_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "YesNoCancel_NoDefault_Click", CMessageBoxButton.YesNoCancel, CMessageBoxImage.None, CMessageBoxDefaultButton.No);

        }

        private void YesNoCancel_CancelDefault_Click(object sender, RoutedEventArgs e)
        {
            CMessageBox.Show("Hello,CMessageBox!", "YesNoCancel_CancelDefault_Click YesNoCancel_CancelDefault_Click", CMessageBoxButton.YesNoCancel, CMessageBoxImage.None, CMessageBoxDefaultButton.Cancel);

        }
    }
}
