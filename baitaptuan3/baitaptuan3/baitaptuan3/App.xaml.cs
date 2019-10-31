using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baitaptuan3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            database db = new database();
            db.createdatabase();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
