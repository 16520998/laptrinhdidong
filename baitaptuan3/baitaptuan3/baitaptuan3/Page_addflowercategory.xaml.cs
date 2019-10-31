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
    public partial class Page_addflowercategory : ContentPage
    {
        public Page_addflowercategory()
        {
            InitializeComponent();
        }

        private void Cmdthem_Clicked(object sender, EventArgs e)
        {
            database db = new database();
            Loaihoa l = new Loaihoa { TenLoai = txttenloai.Text };
            if (db.InsertLoaihoa(l) == true)
            {
                DisplayAlert("Thông báo", "Thêm loại hoa thành công!", "OK");
            }
            else
                DisplayAlert("Thông báo", "Thêm hoa thất bại!", "OK");
        }
    }
}