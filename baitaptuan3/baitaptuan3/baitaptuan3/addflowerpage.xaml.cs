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
    public partial class addflowerpage : ContentPage
    {
        database db;
        List<Loaihoa> dsml;
        public addflowerpage()
        {
            InitializeComponent();
            db = new database();
            db.createdatabase();
            dsml = db.selectLoaihoa();
            selectloai.ItemsSource = dsml;
        }
        private void Cmdthemhoa_Clicked(object sender, EventArgs e)
        {

            Hoa h = new Hoa
            {
                Tenhoa = txttenhoa.Text,
                Maloai = int.Parse(selectloai.SelectedItem.ToString()),
                Mota = txtmota.Text,
                Gia = double.Parse(txtgia.Text),
                Hinh=""
            };
            if (db.Inserthoa(h) == true)
            {
                DisplayAlert("Thông báo", "Thêm loại hoa thành công!", "OK");
            }
            else
                DisplayAlert("Thông báo", "Thêm hoa thất bại!", "OK");
        }
    //    private void Cmdxoahoa_Clicked(object sender, EventArgs e)
    //    {

    //    }
    }

    
}

        
    

   
