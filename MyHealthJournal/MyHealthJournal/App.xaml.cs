﻿using MyHealthJournal.Views;
using Prism.Unity;
using Xamarin.Forms;

namespace MyHealthJournal
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MenuPage/NavigationPage/WelcomePage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MenuPage>();

            Container.RegisterTypeForNavigation<WelcomePage>();
            Container.RegisterTypeForNavigation<MainPage>();

        }
    }
}
