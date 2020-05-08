using BrasilTenis.Models;
using BrasilTenis.Services;
using BrasilTenis.Services.Interfaces;
using BrasilTenis.ViewModels;
using BrasilTenis.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;

namespace BrasilTenis
{
    public partial class App : PrismApplication
    {

        public App() : this(null)
        {
            //InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();
        }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
            
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ItemsPage>();
            //containerRegistry.RegisterForNavigation<ItemsPage, ItemsViewModel>();

            containerRegistry.Register<IDataStore<Item>,MockDataStore>();
        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            Prism.Mvvm.ViewModelLocationProvider.Register<ItemsPage, ItemsViewModel>();
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
