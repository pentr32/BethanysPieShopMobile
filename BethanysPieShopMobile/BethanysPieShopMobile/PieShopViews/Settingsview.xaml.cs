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
    public partial class Settingsview : ContentPage
    {
        public Settingsview()
        {
            InitializeComponent();

            var langaugeList = new List<string> { "English", "Dutch", "French", "German" };
            LanguagePickerFromCode.ItemsSource = langaugeList;
        }

        private void LanguagePickerFromCode_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = ((Picker)sender).SelectedIndex;

            if (selectedIndex != -1)
            {
                SelectedLanguageLabel.Text = (string)LanguagePickerFromCode.ItemsSource[selectedIndex];
            }
        }

        private void PieBudgetSlider_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            PieBudgetLabel.Text = $"{e.NewValue:C}";
        }

        private void MaxPieStepper_OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            MaxPieLabel.Text = $"You can order {e.NewValue} pie(s) per month";
        }

        private async void SaveSettingsButton_OnClicked(object sender, EventArgs e)
        {
            SavingActivityIndicator.IsRunning = true;

            await Task.Delay(2000);

            SavingActivityIndicator.IsRunning = false;

            await DisplayAlert("Success", "Your settings have been saved!", "Done");
        }
    }
}