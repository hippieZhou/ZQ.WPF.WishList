using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using WishList.Commons;

namespace WishList.ViewModels
{
    public class MINOR
    {
        public ViewModelBase Minor_VM { get; set; }
        public DataTemplate Minor_DT { get; set; }
    }

    public class MINORManager
    {
        public static AddViewModel AddVM = new AddViewModel();

        private MINOR Minor { get; set; }

        private static MINORManager _currentMinor;
        public static MINORManager CurrentMinor
        {
            get { return _currentMinor ?? (_currentMinor = new MINORManager()); }
            set { _currentMinor = value; }
        }
        private MINORManager()
        {
            this.Minor = new MINOR();
        }

        internal void PostMinorViewAndViewModel(ViewModelBase vm)
        {
            this.Minor.Minor_VM = vm;
            this.Minor.Minor_DT = DataTemplateSelector.Current.GetDataTemplateByVM(this.Minor.Minor_VM);
            if (this.Minor.Minor_VM != null && this.Minor.Minor_DT != null)
            {
                Messenger.Default.Send<NotificationMessage>(new NotificationMessage(this.Minor, "showMinorViewMsg"), "showMinorView");
            }
        }
    }
}
