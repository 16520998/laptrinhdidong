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
    public partial class Register_Page : ContentPage
    {
        public Register_Page()
        {
            InitializeComponent();
        }

        private void Button_gotologin_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}