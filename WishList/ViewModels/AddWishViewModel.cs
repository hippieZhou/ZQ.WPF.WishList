﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace WishList.ViewModels
{
    public class AddWishViewModel:ViewModelBase
    {
        private RelayCommand _backCmd;

        public RelayCommand BackCmd
        {
            get
            {
                return _backCmd ?? (_backCmd = new RelayCommand(
              () =>
              {
                  Messenger.Default.Send<Visibility>(Visibility.Collapsed, "closeMinorView");
              }));
            }
        }

    }
}
