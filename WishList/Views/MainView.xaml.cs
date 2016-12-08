using System.Drawing;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using WishList.ViewModels;

namespace WishList.Views
{
    /// <summary>
    /// Description for MainView.
    /// </summary>
    public partial class MainView : Window
    {
        private static NotifyIcon notifyIcon;

        /// <summary>
        /// Initializes a new instance of the MainView class.
        /// </summary>
        public MainView()
        {
            InitializeComponent();

            notifyIcon = new NotifyIcon
            {
                BalloonTipText = Properties.Resources.MainView_MainView_WishList,
                BalloonTipTitle = Properties.Resources.MainView_MainView_愿望清单,
                Text = Properties.Resources.MainView_MainView_Main_App,
                Icon = new Icon(@"ic_launcher.ico"),
                Visible = false
            };
            notifyIcon.DoubleClick += (sender, e) =>
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            };

            Messenger.Default.Register<NotificationMessage>(this.minorCC, "showMinorView", ShowMinorViewFunc);
            Messenger.Default.Register<Visibility>(this.minorCC, "closeMinorView", CloseMinorViewFunc);

            this.Closing += (sender, e) =>
            {
                ViewModelLocator.CleanUp();
            };
        }

        private void ShowMinorViewFunc(NotificationMessage obj)
        {
            if (!(obj.Sender is MINOR)) return;
            this.minorCC.Content = this.minorCC.ContentTemplate = null;

            var sender = (MINOR) obj.Sender;
            this.minorCC.Content = sender.Minor_VM;
            this.minorCC.ContentTemplate = sender.Minor_DT;
            this.minorCC.Visibility = Visibility.Visible;
        }
        private void CloseMinorViewFunc(Visibility obj)
        {
            this.minorCC.Visibility = obj;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is System.Windows.Controls.Button)) return;
            var tag = ((System.Windows.Controls.Button) sender).Tag;
            if (tag.Equals("btnMin"))
            {
                this.WindowState = WindowState.Minimized;
                notifyIcon.Visible = true;
            }
            else if (tag.Equals("btnClose"))
            {
                System.Windows.Application.Current.Shutdown();
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }
    }
}