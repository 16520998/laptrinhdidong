using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace baitaptuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagelistviewgroup : ContentPage
    {
        
        public Pagelistviewgroup()
        {
            InitializeComponent();
            Loaihoa l = new Loaihoa();
            lsthoa.ItemsSource = l.loaihoas;
        }
    }
}