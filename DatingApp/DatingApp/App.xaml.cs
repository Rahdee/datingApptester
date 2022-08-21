using DatingApp.ViewModels;
using DatingApp.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace DatingApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LandingTabbedPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<LandingTabbedPage, LandingTabbedPageViewModel>();
            containerRegistry.RegisterForNavigation<MatchesContentPage, MatchesContentPageViewModel>();
            containerRegistry.RegisterForNavigation<ChatsPage, ChatsPageViewModel>();
            containerRegistry.RegisterForNavigation<MyProfilePage, MyProfilePageViewModel>();
        }
    }
}
