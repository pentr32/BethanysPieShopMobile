using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShopMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupView : ContentPage
    {
        public PopupView()
        {
            InitializeComponent();
        }

        private async void btnSimpleAlert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Det her er en alert", "OK");
        }

        private async void AlertYesNo_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Question?", "Vil du gerne spiller med mig?", "Yes", "No");
            Debug.WriteLine("Answer: " + answer);
        }

        private async void ActionSheetSimple_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: Send til", "Cancel", null, "Email", "Twitter", "Facebook");
            Debug.WriteLine("Action: " + action);
        }

        private async void ActionSheetCancelDelete_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("ActionSheet: Gem billede", "Cancel", "Delete", "Photo Roll", "Email");
            Debug.WriteLine("Action: " + action);
        }
    }
}