using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void cmdhello_clicked(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            DisplayAlert("chào", "chào bạn:" + hoten, "Thoát");

        }
        private void back(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}