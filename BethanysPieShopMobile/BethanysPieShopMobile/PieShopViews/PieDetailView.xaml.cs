using BethanysPieShopMobile.Model;
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
	public partial class PieDetailView : ContentPage
	{
		public PieDetailView(Pie pie)
		{
			InitializeComponent();

			//var pie = new Pie
			//{
			//	Id = 1,
			//	Description =
			//	"Gingerbread jujubes donut. Gummies cake halvah. Jujubes candy canes pudding cupcake ice cream bonbon chocolate bar. Pudding apple pie carrot cake lollipop. Caramels sugar plum muffin croissant cake dragée carrot cake jelly-o cotton candy. Jelly beans chocolate pie bear claw donut sesame snaps. Carrot cake tart sweet gummies. Lollipop cotton candy muffin marshmallow chocolate bar danish. Tart donut fruitcake. Toffee candy danish chocolate danish toffee chocolate bar. Ice cream chocolate cake gingerbread. Brownie tootsie roll cotton candy cookie bear claw cheesecake cupcake lollipop apple pie.",
			//	ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
			//	InStock = true,
			//	PieName = "Apple pie",
			//	Price = 20.95
			//};

			BindData(pie);

		}

		private void BindData(Pie pie)
		{
			PieNameLabel.Text = pie.PieName;
			PieImage.Source = pie.ImageUrl;
			DescriptionLabel.Text = pie.Description;
			PriceLabel.Text = pie.Price.ToString("c");
			InStockLabel.Text = pie.InStock ? "In stock" : "Not in stock";
		}

		private async void AddToBasketButton_OnClicked(object sender, EventArgs e)
		{
			await DisplayAlert("Success", "Pie added to baskey!", "Done");
		}
	}
}