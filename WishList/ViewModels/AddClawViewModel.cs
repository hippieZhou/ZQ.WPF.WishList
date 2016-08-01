using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Diagnostics;
using System.Windows;

namespace WishList.ViewModels
{
    public class AddClawViewModel:ViewModelBase
    {
        private string _sum = "0";
        public string Sum
        {
            get { return _sum; }
            set { Set(ref _sum, value); }
        }

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

        private RelayCommand<string> _putCmd;
        public RelayCommand<string> PutCmd
        {
            get
            {
                return _putCmd ?? (_putCmd = new RelayCommand<string>(
              (obj) =>
              {
                  if (Convert.ToDouble(this.Sum.Trim()) == 0)
                  {
                      this.Sum = obj;
                  }
                  else
                  {
                      this.Sum = string.Format("{0}{1}", this.Sum, obj);
                  }
              }));
            }
        }

        private RelayCommand _delCmd;
        public RelayCommand DelComd
        {
            get
            {
                return _delCmd ?? (_delCmd = new RelayCommand(
              () =>
              {
                  if (Convert.ToDouble(this.Sum) > 0)
                  {
                      if (this.Sum.Length > 1)
                      {
                          this.Sum = this.Sum.Remove(this.Sum.Length - 1);
                      }
                      else
                      {
                          this.Sum = "0";
                      }
                  }
              }));
            }
        }

        private RelayCommand _yesCmd;
        public RelayCommand YesCmd
        {
            get
            {
                return _yesCmd ?? (_yesCmd = new RelayCommand(
              () =>
              {

              }));
            }
        }

    }
}
