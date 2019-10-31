using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baitaptuan3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListflower : ContentPage
    {
        database db;
        List<Loaihoa> dsl;
        public PageListflower()
        {
            InitializeComponent();
            db = new database();
            dsl = db.selectLoaihoa();
            lstdsloai.ItemsSource = dsl;
        }

        private void tapped(object sender, ItemTappedEventArgs e)
        {

            var lh = e.Item as Loaihoa;
            Navigation.PushAsync(new HoaPage(lh.MaLoai));
            
        }
    }
}