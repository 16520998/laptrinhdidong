using System;
using System.Collections.Generic;
using System.Text;

namespace BanNuochoa.Models
{
    class products
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> id_thuonghieu { get; set; }
        public Nullable<int> id_loai { get; set; }
        public string gioitinh { get; set; }
        public Nullable<int> @new { get; set; }
        public string description { get; set; }
       //public double? unit_price { get; set; }

        public Nullable<double> promotion_price { get; set; }
        //public string unit_price { get; set; }
        public Nullable<double> unit_price { get; set; }
        //public string promotion_price { get; set; }
        public string image { get; set; }
    }
}
