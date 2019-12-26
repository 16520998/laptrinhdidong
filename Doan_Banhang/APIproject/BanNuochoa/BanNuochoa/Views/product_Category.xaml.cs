using BanNuochoa.Models;
using BanNuochoa.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BanNuochoa.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class product_Category : ContentPage
    {
        
        public product_Category(int id)
        {
            InitializeComponent();

            BindingContext = new product_Category_Viewmodels(id);

        }
        private async void Detail_Products(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as products;
            await Navigation.PushModalAsync(new Product_Details(details.description, details.name, details.unit_price, details.image));
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