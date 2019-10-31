using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace baitaptuan3
{
    class Loaihoa
    {
        [PrimaryKey, AutoIncrement] // ma loai la khoa chinh, co gia tri tu tang
        public int MaLoai { get; set; }
        public String TenLoai { get; set; }

    }
}
