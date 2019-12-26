using BanNuochoa.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BanNuochoa.ViewModels
{
     class product_type_dataViewModels:INotifyPropertyChanged
    {
        private ObservableCollection<product_Type> _product_Types;
        public ObservableCollection<product_Type> product_Types {
            get { return _product_Types; } 
            set{ _product_Types = value;
                OnPropertyChanged(); }  
        }


        public product_type_dataViewModels(){
            product_Types = new ObservableCollection<product_Type>()
            {
                new product_Type(){name="Nước hoa nhập khẩu", id=1,image="nuochoanhapkhau.jpg"},
                new product_Type(){name ="Nước hoa nội",id=2,image="nuochoanoi.jpg"},
                new product_Type(){name="Nước hoa công sở",id=3,image="nuochoacongso.jpg"},
                new product_Type(){name="Nước hoa du lịch",id=4,image="nuochoadulich.png"}
            };
        }
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
