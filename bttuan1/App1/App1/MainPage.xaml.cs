using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
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
        private void bt_click1(object sender, EventArgs e)
        {
             Navigation.PushAsync(new Page1());
        }
        private void bt_click2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new tinhtong());
        }
        private void bt_login(object sender, EventArgs e)
        {
            Navigation.PushAsync(new login());
        }
        private void bt_cal(object sender, EventArgs e)
        {
            Navigation.PushAsync(new calculator());
        }
        //public void gridlayout()
        //{
        //    InitializeComponent();
        //    var grid = new Grid();
        //    Title = "grid Layout Exploration-code";
        //    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        //    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
        //    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
        //    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

        //    var topleft = new Label { Text = "tren trai" };
        //    var topright = new Label { Text = "tren phai" };
        //    var bottomlef = new Label { Text = "duoi trai" };
        //    var bottomright = new Label { Text = "duoi phai" };

        //    grid.Children.Add(topleft, 0, 0);
        //    grid.Children.Add(topright, 0, 1);
        //    grid.Children.Add(bottomlef, 0, 1);
        //    grid.Children.Add(bottomright, 1, 1);
        //    Content = grid;

        //}
    }

   
}
