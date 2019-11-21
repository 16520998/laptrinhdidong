using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace tuan4.Models
{
    public class LoaiHoa
    {
        [PrimaryKey, AutoIncrement]
        public int Maloai { get; set; }
        public string Tenloai { get; set; }
    }
}
