using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tuan4.Models;

namespace tuan4.helpers
{
    public class Database
    {
        string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public Database()
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    //tao 2 bang
                    connection.CreateTable<LoaiHoa>();
                    connection.CreateTable<Hoa>();
                }
            }
            catch (SQLiteException ex) { };
        }
    
    #region "Loại Hoa"
    public List<LoaiHoa> GetLoaiHoas()
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
            {
                return connection.Table<LoaiHoa>().ToList();
            }
        }
        catch (SQLiteException ex)
        {
            return null;
        }
    }
    public LoaiHoa GetLoaiHoaByid(int Maloai)
    {
        try
        {
            using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
            {
                var dsh = from lhs in connection.Table<LoaiHoa>().ToList()
                          where lhs.Maloai == Maloai
                          select lhs;
                return dsh.ToList<LoaiHoa>().FirstOrDefault();
            }
        }
        catch (SQLiteException ex)
        {
            return null;
        }
    }
        public bool InsertLoaihoa(LoaiHoa lh)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(lh);
                    return true;
                }

            }
            catch (SQLiteException ex) { return false; }
        }
        public bool UpdateLoaihoa(LoaiHoa h)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Update(h);
                    return true;
                }

            }
            catch (SQLiteException ex) { return false; }
        }
        public bool DeleteLoaihoa(LoaiHoa h)
        {
            try
            {
                using (var connection = new SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Delete(h);
                    return true;
                }

            }
            catch (SQLiteException ex) { return false; }
        }
        #endregion
    }
}
