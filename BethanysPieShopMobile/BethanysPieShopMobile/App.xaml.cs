using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ContentPageView();
            //MainPage = new NavigationPage(new NavigationPageView());
            //MainPage = new TabbedPageView();
            //MainPage = new MasterDetailPageView();
            //MainPage = new CarouselPageView();
            //MainPage = new ModalPageView();
            //MainPage = new PopupView();
            //MainPage = new LoginWithStackLayout();
            //MainPage = new PieShopViews.LoginView();
            //MainPage = new PieShopViews.RegisterView();
            //MainPage = new PieShopViews.ContactView();
            //MainPage = new PieShopViews.Settingsview();
            //MainPage = new PieShopViews.WebPageView();
            //MainPage = new PieOverview();

            var alreadyRegistered = false;

            if (alreadyRegistered)
                MainPage = new MainView();
            else
                MainPage = new NavigationPage(new PieShopViews.LoginView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
