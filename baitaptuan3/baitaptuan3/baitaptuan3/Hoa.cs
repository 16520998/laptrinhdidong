using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace baitaptuan3
{
    class Hoa
    {
        [PrimaryKey, AutoIncrement]
        public int Mahoa { get; set; }
        public int Maloai { get; set; }
        public String Tenhoa { get; set; }
        public String Hinh { get; set; }
        public String Mota { get; set; }
        public double Gia { get; set; }

    }
}
