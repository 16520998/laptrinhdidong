using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
namespace baitaptuan3
{
    class database
    {// lấy thư mục lưu trữ csdl trên hệ thống 
        String folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool createdatabase()
        {
            try {//tạo csdl
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {// tao 2 bang
                    connection.CreateTable<Loaihoa>();
                    connection.CreateTable<Hoa>();
                    return true;
                }
            }
            catch (SQLiteException ex) {
                //Log.info("SQLiteEx",ex.message);
                return false;
            }
        }
        public bool InsertLoaihoa(Loaihoa loai)
        {
            try {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(loai);
                    return true;
                }
            }
            catch (SQLiteException ex) {
                return false;
            }
        }
        public bool UpdateLoaihoa(Loaihoa loai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Update(loai);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
        public bool DeleteLoaihoa(Loaihoa loai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Delete(loai);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
        public List<Loaihoa> selectLoaihoa()
        {
            try {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Loaihoa>().ToList(); // select loai hoa
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }
        public Loaihoa selectLoaihoaByid(int id)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var lh = from l in connection.Table<Loaihoa>().ToList()
                             where l.MaLoai == id
                             select l;

                    return lh.ToList().FirstOrDefault(); // select loai hoa
                }
            }
            catch (SQLiteException ex)
            {
                return null;// k tim thay thi tra ve null
            }
        }
        public List<Hoa> selectHoatheoloai(int maloai)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var dsh = from lhs in connection.Table<Hoa>().ToList()
                              where lhs.Maloai == maloai
                              select lhs;

                    return dsh.ToList<Hoa>(); // select loai hoa
                }
            }
            catch (SQLiteException ex)
            {
                return null;// k tim thay thi tra ve null
            }
        }
        public List<object> selectHoa1()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var Banghoa = connection.Table<Hoa>();
                    var Bangloai = connection.Table<Loaihoa>();
                    var kq = from h in Banghoa
                             join lh in Bangloai on h.Maloai equals lh.MaLoai
                             select new { h.Mahoa, h.Tenhoa, h.Hinh, h.Gia, h.Maloai, h.Mota, lh.TenLoai };

                    return kq.ToList<object>(); // select loai hoa
                }
            }
            catch (SQLiteException ex)
            {
                return null;// k tim thay thi tra ve null
            }
        }
        public List<object> selectLoaihoa1()
        { try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    var lh1 = from h in connection.Table<Hoa>()
                              group h by h.Maloai into kq
                              select new { Maloai = kq.Key, Tongsohoa = kq.Count() };// tong so hoa theo loai
                    var lh2 = from lh in connection.Table<Loaihoa>()
                              join l1 in lh1 on lh.MaLoai equals l1.Maloai // giao 2 bang lai va group by theo maloai , lay ton so hoa la count
                             select new { lh.MaLoai, lh.TenLoai, l1.Tongsohoa };
                    return lh2.ToList<object>();
                }
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }
        public bool Inserthoa(Hoa h )
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                return false;
            }
        }
    }
    
}
