using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile.PieShopViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void LoginButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new MainView(), this);     // Brugeren er authentikeret
            await Navigation.PopAsync();
        }
    }
}