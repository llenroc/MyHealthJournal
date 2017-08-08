using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Threading.Tasks;

namespace MyHealthJournal.ViewModels
{
    public class MenuPageViewModel : BindableBase
    {

        #region Commands

        public DelegateCommand ShowMainPageCommand => new DelegateCommand(async() => await ExecuteShowMainPageAsync());

        public DelegateCommand ShowWelcomePageCommand => new DelegateCommand(async() => await ExecuteShowWelcomePageAsync());

        #endregion



        INavigationService _navigationService;

        public MenuPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        private async Task ExecuteShowMainPageAsync()
        {
            await _navigationService.NavigateAsync("NavigationPage/MainPage");
        }

        private async Task ExecuteShowWelcomePageAsync()
        {
            await _navigationService.NavigateAsync("NavigationPage/WelcomePage");
        }
    }
}
