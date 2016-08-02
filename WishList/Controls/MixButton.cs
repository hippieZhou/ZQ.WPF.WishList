using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WishList
{
    public class MixButton : Button
    {
        static MixButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MixButton), new FrameworkPropertyMetadata(typeof(MixButton)));
        }



        public ImageSource Logo
        {
            get { return (ImageSource)GetValue(LogoProperty); }
            set { SetValue(LogoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Logo.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LogoProperty =
            DependencyProperty.Register("Logo", typeof(ImageSource), typeof(MixButton), new PropertyMetadata(null));



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(MixButton), new PropertyMetadata(string.Empty));


    }
}
