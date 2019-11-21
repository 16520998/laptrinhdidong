using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using tuan4.Models;

namespace tuan4.Interface
{
    public interface ILoaiHoaRespository // định nghĩa các phương thức trong respon giống như hướng đối tượng
    {
        ObservableCollection<LoaiHoa> GetLoaiHoas(); 
        LoaiHoa GetLoaiHoaByid(int Maloai);
        bool Insert(Models.LoaiHoa h);
        bool Update(Models.LoaiHoa h);
        bool Delete(Models.LoaiHoa h);
    }
}
