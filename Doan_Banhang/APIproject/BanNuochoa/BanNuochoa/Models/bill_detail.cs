using System;
using System.Collections.Generic;
using System.Text;

namespace BanNuochoa.Models
{
    class bill_detail
    {
        public int id { get; set; }
        public string tensanpham  { get; set; }
        public int quantity { get; set; }
        public double Total { get; set; }
        public string customer  { get; set; }
        public string Note { get; set; }

    }
}
