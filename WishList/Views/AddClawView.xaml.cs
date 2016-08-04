using System.Windows;
using System.Windows.Controls;

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
