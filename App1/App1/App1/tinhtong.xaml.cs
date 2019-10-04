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
    public partial class tinhtong : ContentPage
    {
        public tinhtong()
        {
            InitializeComponent();
        }
        private void bt_tinhtong(object sender, EventArgs e)
        {
            Double a, b,tong;
            a = Double.Parse(txta.Text);
            b = Double.Parse(txtb.Text);
            tong = a + b;
            txttong.Text = tong.ToString();
        }
        private void back(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}