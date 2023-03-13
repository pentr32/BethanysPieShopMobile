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
    public partial class RegisterView : ContentPage
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private async void BirthdayDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            if(BirthdayDatePicker.Date == DateTime.Today)
            {
                await DisplayAlert("Alert", "You weren't born today I guess!", "OK");
            }
        }

        private void UserNameEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableRegisterButton();
        }

        private void PasswordEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableRegisterButton();
        }

        private void EnableRegisterButton()
        {
            if (!string.IsNullOrEmpty(UserNameEntry.Text) && !string.IsNullOrEmpty(PasswordEntry.Text)) 
                RegisterButton.IsEnabled = true; 

            else RegisterButton.IsEnabled = false;
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have registered successfully!", "OK");
            
        }
    }
}