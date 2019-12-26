using BanNuochoa.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;

namespace BanNuochoa.ViewModels
{
    class ProductViewModel:INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private int _id_thuonghieu;
        private int _id_loai;
        private string _gioitinh;
        private string _description;
        private double _unit_price;
        //private string _unit_price;
        private string _image;

  
        private List<products> _listProducts;
        public List<products> listProducts
        {
            get { return _listProducts; }
            set
            {
                _listProducts = value;
                OnPropertyChanged();
            }
        }
        public ProductViewModel()
        {
            GetProductAsync("http://localhost:3000/products/");
        }
        public async void GetProductAsync(string path)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            System.Diagnostics.Debug.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                //var newConten = content
                //var o = JsonConvert.DeserializeObject<JObject>(content);
                listProducts = JsonConvert.DeserializeObject<List<products>>(content);
                //listProducts = await response.Content.ReadAsAsync<List<products>>();
            }
            else
            {
                listProducts = null;
            }
        }
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string name
        {
            get { return _name; }
            set { _name = value;
                OnPropertyChanged();
            }
        }
        public int id_thuonghieu
        {
            get
            {
                return _id_thuonghieu;
            }
            set
            {
                _id_thuonghieu = value;
                OnPropertyChanged();
            }
        }
        public int id_loai
        {
            get
            {
                return _id_loai;
            }
            set
            {
                _id_loai = value;
                OnPropertyChanged();
            }
        }
        public string gioitinh
        {
            get
            {
                return _gioitinh;
            }
            set
            {
                _gioitinh = value;
                OnPropertyChanged();
            }
        }
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }
        public double unit_price//danh dau
        {
            get
            {
                return _unit_price;
            }
            set
            {
                _unit_price = value;
                OnPropertyChanged();
            }
        }

        public string image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                OnPropertyChanged();
            }
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
