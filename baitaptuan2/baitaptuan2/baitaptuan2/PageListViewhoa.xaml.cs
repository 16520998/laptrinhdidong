using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baitaptuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListViewhoa : ContentPage
    {
        ObservableCollection<flower> flowers = new ObservableCollection<flower>();
        public PageListViewhoa()
        {
            InitializeComponent();
            flowers.Add(new flower { flowername = "đón xuân", price = 60000, image = "cucvangcacmau.jpg", describe = "hoa cúc đẹp, trắng, vàng, cam" });
            flowers.Add(new flower { flowername = "Hồn nhiên", price = 70000, image = "hoacucvang.jpg", describe = "hoa cúc vàng, cam. lá me" });
            flowers.Add(new flower { flowername = "hoa cúc tím", price = 60000, image = "cuctim.jpg", describe = "hoa cúc tím rất đẹp thầy ạ!" });
            lsvflower.ItemsSource = flowers;
            
        }
    }
}