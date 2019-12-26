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
    public partial class OrderPage : ContentPage
    {
  
        public OrderPage(string name, string price, string img)
        {

            InitializeComponent();
            BindingContext = new bill_detail_Viewmodel(name, price, img);
           
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        }
    }
}