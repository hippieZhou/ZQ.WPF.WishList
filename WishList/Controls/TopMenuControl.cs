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
    public class TopMenuControl : RadioButton
    {
        static TopMenuControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TopMenuControl), new FrameworkPropertyMetadata(typeof(TopMenuControl)));
        }

        protected override void OnChecked(RoutedEventArgs e)
        {
            this.Background = CheckBrush;
            base.OnChecked(e);
        }

        protected override void OnUnchecked(RoutedEventArgs e)
        {
            this.Background = Brushes.Transparent;
            base.OnUnchecked(e);
        }



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TopMenuControl), new PropertyMetadata(string.Empty));



        public Brush CheckBrush
        {
            get { return (Brush)GetValue(CheckBrushProperty); }
            set { SetValue(CheckBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckBrushProperty =
            DependencyProperty.Register("CheckBrush", typeof(Brush), typeof(TopMenuControl), new PropertyMetadata(Brushes.Transparent));
    }
}
