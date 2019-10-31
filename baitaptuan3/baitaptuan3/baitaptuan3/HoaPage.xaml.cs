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
    public partial class HoaPage : ContentPage
    {
        int malh;
        List<Hoa> dshoa;
        database db;
        
        public HoaPage()
        {
            InitializeComponent();
        }
        public HoaPage(int maloai)
        {
            db = new database();
            db.createdatabase();
            dshoa = db.selectHoatheoloai(maloai);
            DSHoa.ItemsSource = dshoa;
            malh = maloai;
        }
    }
}