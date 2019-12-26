using BanNuochoa.Models;
using BanNuochoa.ViewModels;
using BanNuochoa.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BanNuochoa
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ProductViewModel();
           //this.BindingContext = new Customer_ViewModels();
        }
        private async void Detail_Products(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as products;
            await Navigation.PushModalAsync(new Product_Details(details.description, details.name, details.unit_price,details.image));
        }
        
       
        private async void btlogin_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushModalAsync(new NavigationPage (new Register_Page()));
        }

        private async void loainuochoa_Clicked(object sender, EventArgs e)
        {
          await  Navigation.PushModalAsync(new NavigationPage (new products_type()));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)//create search bar 
        {
            var timkiem = BindingContext as ProductViewModel;
            productlistview.BeginRefresh();
            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                productlistview.ItemsSource = timkiem.listProducts;
            else
                productlistview.ItemsSource = timkiem.listProducts.Where(i => i.name.Contains(e.NewTextValue));
            productlistview.EndRefresh();
        }
    }
}
