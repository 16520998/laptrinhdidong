using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using tuan4.helpers;
using tuan4.Models;

namespace tuan4.Respository
{
    class LoaiHoaRepository : Interface.ILoaiHoaRespository
    {
        Database db;
        public LoaiHoaRepository()
        {
            db = new Database();
        }
        public bool Delete(LoaiHoa h)
        {
            return db.DeleteLoaihoa(h);
        }

        public LoaiHoa GetLoaiHoaByid(int Maloai)
        {
            return db.GetLoaiHoaByid(Maloai);
        }

        public ObservableCollection<LoaiHoa> GetLoaiHoas()
        {
            return new ObservableCollection<LoaiHoa>(db.GetLoaiHoas());
        }

        public bool Insert(LoaiHoa h)
        {
            return db.InsertLoaihoa(h);
        }

        public bool Update(LoaiHoa h)
        {
           return  db.UpdateLoaihoa(h);
        }
    }
}
