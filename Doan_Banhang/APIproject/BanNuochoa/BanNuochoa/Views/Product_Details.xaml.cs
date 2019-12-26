using BanNuochoa.Models;
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
    public partial class Product_Details : ContentPage
    {
        public Product_Details(string name, string description, double ? unit_price, string image)// sửa cũng ở đây
        {
            InitializeComponent();
            P_name.Text = description;
            p_price.Text = unit_price.ToString();
            p_description.Text = name;
            p_image.Source = image;
   
        }

        private async void dathang_Clicked(object sender, EventArgs e)
        {
                 await Navigation.PushModalAsync(new OrderPage(P_name.Text, p_price.Text, p_image.Source.ToString()));
        }
    }
}