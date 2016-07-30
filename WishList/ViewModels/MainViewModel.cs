using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using WishList.Commons;

namespace WishList.ViewModels
{
    public class MainViewModel:ViewModelBase
    {
        public readonly string ClawStr = Application.Current.Resources["ClawStr"] as string;
        public readonly string WishStr = Application.Current.Resources["WishStr"] as string;
        public readonly string ListStr = Application.Current.Resources["ListStr"] as string;
        public readonly string MineStr = Application.Current.Resources["MineStr"] as string;

        public static ClawViewModel ClawVM = new ClawViewModel();
        public static WishViewModel WishVM = new WishViewModel();
        public static ListViewModel ListVM = new ListViewModel();
        public static MineViewModel MineVM = new MineViewModel();

        public DataTemplate CurrentDT
        {
            get
            {
                return DataTemplateSelector.Current.GetDataTemplateByVM(this.CurrentVM);
            }
        }
        private ViewModelBase _currentVM;
        public ViewModelBase CurrentVM
        {
            get { return _currentVM ?? (_currentVM = ClawVM); }
            set
            {
                Set(ref _currentVM, value);
                this.RaisePropertyChanged(() => this.CurrentDT);
            }
        }

        private RelayCommand<string> _menuCmd;
        public RelayCommand<string> MenuCmd
        {
            get
            {
                return _menuCmd ?? (_menuCmd = new RelayCommand<string>(
                    (obj) =>
                    {
                        if (obj.Equals(WishStr))
                        {
                            this.CurrentVM = WishVM;
                        }
                        else if (obj.Equals(ListStr))
                        {
                            this.CurrentVM = ListVM;
                        }
                        else if (obj.Equals(MineStr))
                        {
                            this.CurrentVM = MineVM;
                        }
                        else
                        {
                            this.CurrentVM = ClawVM;
                        }
                    }));
            }
        }

        private RelayCommand _addCmd;
        public RelayCommand AddCmd
        {
            get
            {
                return _addCmd ?? (_addCmd = new RelayCommand(
                    () =>
                    {
                        MINORManager.CurrentMinor.PostMinorViewAndViewModel(MINORManager.AddVM);
                    }));
            }
        }
    }
}
