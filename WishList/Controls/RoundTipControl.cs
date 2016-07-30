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
    public class RoundTipControl : RadioButton
    {
        static RoundTipControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundTipControl), new FrameworkPropertyMetadata(typeof(RoundTipControl)));
        }

        public string Tip
        {
            get { return (string)GetValue(TipProperty); }
            set { SetValue(TipProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Tip.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TipProperty =
            DependencyProperty.Register("Tip", typeof(string), typeof(RoundTipControl), new PropertyMetadata(string.Empty));

        public ImageSource TipLog
        {
            get { return (ImageSource)GetValue(TipLogProperty); }
            set { SetValue(TipLogProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TipLog.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TipLogProperty =
            DependencyProperty.Register("TipLog", typeof(ImageSource), typeof(RoundTipControl), new PropertyMetadata(null));

        public Brush CheckBrush
        {
            get { return (Brush)GetValue(CheckBrushProperty); }
            set { SetValue(CheckBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CheckBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CheckBrushProperty =
            DependencyProperty.Register("CheckBrush", typeof(Brush), typeof(RoundTipControl), new PropertyMetadata(null));
    }
}
