﻿using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WishList.ViewModels;

namespace WishList.Views
{
    /// <summary>
    /// Description for MainView.
    /// </summary>
    public partial class MainView : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainView class.
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            Messenger.Default.Register<NotificationMessage>(this.minorCC, "showMinorView", ShowMinorViewFunc);
            Messenger.Default.Register<Visibility>(this.minorCC, "closeMinorView", CloseMinorViewFunc);

        }

        private void ShowMinorViewFunc(NotificationMessage obj)
        {
            if (obj.Sender is MINOR)
            {
                this.minorCC.Content = this.minorCC.ContentTemplate = null;

                var sender = obj.Sender as MINOR;
                this.minorCC.Content = sender.Minor_VM;
                this.minorCC.ContentTemplate = sender.Minor_DT;
                this.minorCC.Visibility = Visibility.Visible;
            }
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
            if (sender is Button)
            {
                var Tag = (sender as Button).Tag;
                if (Tag.Equals("btnMin"))
                {
                    this.WindowState = System.Windows.WindowState.Minimized;
                }
                else if (Tag.Equals("btnClose"))
                {
                    Application.Current.Shutdown();
                }
                else
                {
                    this.WindowState = System.Windows.WindowState.Normal;
                }
            }
        }
    }
}