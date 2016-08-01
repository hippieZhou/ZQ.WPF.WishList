using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace WishList.ViewModels
{
    /// <summary>
    /// 愿望
    /// </summary>
    public class WishViewModel:ViewModelBase
    {
        private RelayCommand _addCmd;
        public RelayCommand AddCmd
        {
            get
            {
                return _addCmd ?? (_addCmd = new RelayCommand(
              () =>
              {
                  MINORManager.CurrentMinor.PostMinorViewAndViewModel(MINORManager.AddWishVM);
              }));
            }
        }
    }
}
