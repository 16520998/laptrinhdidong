using BanNuochoa.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BanNuochoa.ViewModels
{
    public class bill_detail_Viewmodel : INotifyPropertyChanged
    {
        private int _id;
        private string _tensanpham;
        private int _quantity;
        private double _Total;
        private string _customer;
        private string _Note;
        private double _price;
        private string _img;
        public double price 
        { 
            get { return _price; }
            
            set{ _price = value;
                OnPropertyChanged(); 
            } 
        }
        public string img
        {
            get { return _img; }
            set
            {
                _img = value;
                OnPropertyChanged();  }
        }
        public ICommand DathangCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var bill = new bill_detail
                    {
                       tensanpham = tensanpham,
                        quantity = quantity,
                        Total = price*quantity,
                        customer = customer,
                        Note = Note,
                    };
                    try
                    {
                        HttpClient client = new HttpClient();
                        string jsonData = JsonConvert.SerializeObject(bill);
                        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync("http://localhost:3000/bill", content);
                        response.EnsureSuccessStatusCode();
                        if (response.IsSuccessStatusCode)
                        {
                            await Application.Current.MainPage.DisplayAlert("Notify?", "Đặt hàng thành công", "Yes");

                            await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());

                        }
                        else
                        {
                            await Application.Current.MainPage.DisplayAlert("Error", "đặt hàng thất bại!, Thử lại", "Ok");
                        }
                    }
                    catch
                    {
                        await Application.Current.MainPage.DisplayAlert("Thông báo:", "vui lòng nhập số lượng và tên khách hàng!", "Ok");
                    }



                });
            }

        }

        public int id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string tensanpham
        {
            get { return _tensanpham; }
            set
            {
                _tensanpham = value;
                OnPropertyChanged();
            }
        }
        public int quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }
        public double Total
        {
            get { return _Total; }
            set
            {
                _Total = value;
                OnPropertyChanged();
            }
        }
        public string customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged();
            }
        }
        public string Note
        {
            get { return _Note; }
            set
            {
                _Note = value;
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

        public bill_detail_Viewmodel(string name, string price, string img)
        {
            tensanpham = name;
            this.price = Convert.ToDouble(price);
            this.img = img;
        }
    }
}

