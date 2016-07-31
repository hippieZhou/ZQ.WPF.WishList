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

namespace WishList.Views
{
    /// <summary>
    /// MinorView.xaml 的交互逻辑
    /// </summary>
    public partial class AddClawView : UserControl
    {
        public AddClawView()
        {
            InitializeComponent();
        }

        private void RoundTipControl_GotFocus(object sender, RoutedEventArgs e)
        {
            var handler = (RoundTipControl)sender;
        }

        private void TopMenuControl_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is TopMenuControl && this.MainCC != null)
            {
                var handler = (TopMenuControl)sender;
                this.MainCC.ContentTemplate = this.Resources[handler.Tag.ToString()] as DataTemplate;
            }
        }
    }
}
