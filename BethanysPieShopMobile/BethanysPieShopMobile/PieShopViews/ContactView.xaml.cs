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
    public partial class ContactView : ContentPage
    {
        public ContactView()
        {
            InitializeComponent();
        }

        private void SendMessageButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Message sent successfully", "Done");
        }
    }
}