using Prism.Mvvm;

namespace MyHealthJournal.ViewModels
{
    public class BaseViewModel : BindableBase
    {

        #region Props

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { SetProperty(ref _isBusy, value); }
        }

        #endregion 

    }
}
