using System;
using System.Collections.Generic;
using System.Text;

namespace baitaptuan2
{
    class flower
    {      
            public string flowername { get; set; }
            public string image { get; set; }
            public double price { get; set; }
            public string describe { get; set; }       
    }
    class Loaihoa : List<flower>
    {
        public string Tenloai { get; set; }
        private Loaihoa(String tenloai)
        {
            Tenloai = tenloai;
        }
        public IList<Loaihoa> loaihoas { get; set; }
        public Loaihoa()
       {
            List<Loaihoa> l = new List<Loaihoa>
        {
            new Loaihoa("hoa cúc")
           {
                new flower { flowername ="đón xuân", price = 50000, image ="hoacucvang.jpg",
                    describe = " hoa cúc các màu : trắng, vàng, cam, lá măng"},
               new flower { flowername ="Hồn nhiên", price = 60000, image ="cucvangcacmau.jpg",
                    describe = " hoa cúc vàng, cam, lá măng"},
               new flower { flowername ="tím thủy chung", price = 45000, image ="cuctim.jpg",
                  describe = " hoa cúc tím"}

           },
            new Loaihoa("hoa cưới")
            {
                new flower { flowername ="dây tơ hường", price = 250000, image ="hoahongtim.jpg",
                   describe = " hoa hồng màu đậm,hoa hồng xanh"},
                new flower { flowername ="cầu thủy tinh", price = 160000, image ="thuytientrang.jpg",
                   describe = " hoa hồng and hoa thủy tiên trắng"},
                new flower { flowername ="duyên trời", price = 445000, image ="hoahongtrang.jpg",
                   describe = " hoa hồng trắng, baby cute hột me"}
            }
       };
       loaihoas = l;
    }

  }
}
