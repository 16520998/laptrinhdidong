using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace baitaptuan3
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cmdthemloaihoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page_addflowercategory());
        }

        private void Cmddsloaihoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageListflower());
        }

        private void Cmdthemhoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addflowerpage());
        }
    }
}
