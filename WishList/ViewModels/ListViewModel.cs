using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace WishList.ViewModels
{
    /// <summary>
    /// 报表
    /// </summary>
    public class ListViewModel:ViewModelBase
    {
        private RelayCommand _openScheduleCmd;

        /// <summary>
        /// Gets the OpenScheduleCmd.
        /// </summary>
        public RelayCommand OpenScheduleCmd
        {
            get
            {
                return _openScheduleCmd ?? (_openScheduleCmd = new RelayCommand(
                    () =>
                    {
                        MINORManager.CurrentMinor.PostMinorViewAndViewModel(MINORManager.AddScheduleVM);
                    }));
            }
        }
    }
}
