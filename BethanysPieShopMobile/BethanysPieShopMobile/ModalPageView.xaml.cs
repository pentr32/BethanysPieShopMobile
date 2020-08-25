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
    public partial class ModalPageView : ContentPage
    {
        public ModalPageView()
        {
            InitializeComponent();
        }

        private async void btnView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new LargeImagePageView());
        }
    }
}