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

namespace WishList
{
    public class RoundMenuControl : RadioButton
    {
        static RoundMenuControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundMenuControl), new FrameworkPropertyMetadata(typeof(RoundMenuControl)));
        }
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
         

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(RoundMenuControl), new PropertyMetadata(string.Empty));



        public ImageSource CheckedImage
        {
            get { return (ImageSource)GetValue(CheckedImageProperty); }
            set { SetValue(CheckedImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckedImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckedImageProperty =
            DependencyProperty.Register("CheckedImage", typeof(ImageSource), typeof(RoundMenuControl), new PropertyMetadata(null));



        public ImageSource UnCheckedImage
        {
            get { return (ImageSource)GetValue(UnCheckedImageProperty); }
            set { SetValue(UnCheckedImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UnCheckedImage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UnCheckedImageProperty =
            DependencyProperty.Register("UnCheckedImage", typeof(ImageSource), typeof(RoundMenuControl), new PropertyMetadata(null));
    }
}
