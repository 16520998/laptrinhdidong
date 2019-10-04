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
    public partial class calculator : ContentPage
    {
        public calculator()
        {
            InitializeComponent();
        }
        private void Onclicked_Number(object sender, EventArgs e) { }
    }
}