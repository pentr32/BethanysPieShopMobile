using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void BasketButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.BasketView());
        }

        private async void HomePageButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.HomePageView());
        }

        private async void ContactUsButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.ContactUsView());
        }

        private async void PieOverviewButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.PieOverviewView());
        }

        private async void btnCalc_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.Calculator());
        }
    }
}