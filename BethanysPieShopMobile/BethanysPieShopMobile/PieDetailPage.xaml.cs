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
    public partial class PieDetailPage : ContentPage
    {
        public Pie Pie { get; set; }
        public PieDetailPage()
        {
            InitializeComponent();

            Pie = new Pie()
            {
                Id = 1,
                Description = "Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake dragée carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                InStock = true,
                AvailableFromDate = new DateTime(2018, 12, 1),
                PieName = "Apple pie",
                Price = 20.95
            };

            this.BindingContext = Pie;
        }

        private async void SavePieButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Pie saved!", "OK");
        }
    }
}