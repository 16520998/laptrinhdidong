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
    public partial class products_type : ContentPage
    {
        public products_type()
        {
            InitializeComponent();
            this.BindingContext = new product_type_dataViewModels();
        }
        private  void productlistview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details= e.Item as product_Type;
             Navigation.PushModalAsync(new product_Category(details.id));

        }
    }
}