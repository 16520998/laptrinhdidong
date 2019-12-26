using BanNuochoa.Models;
using BanNuochoa.Views;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BanNuochoa.ViewModels
{
    public class UserRegister_ViewModels : INotifyPropertyChanged
    {
        
        private string _full_name { get; set; }
        private string _email { get; set; }
        private string _password { get; set; }
        private string _phone { get; set; }
        private string _address { get; set; }
        private string _message { get; set; }
       
        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                   var user = new Users
                    {
                        email = email,
                        full_name = full_name,
                        phone = phone,
                        address = address,
                        password = password,
                    };
                    try
                    {
                        HttpClient client = new HttpClient();
                        string jsonData = JsonConvert.SerializeObject(user);
                        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                        HttpResponseMessage response = await client.PostAsync("http://localhost:3000/users/Register", content);
                        response.EnsureSuccessStatusCode();
                        if (response.IsSuccessStatusCode)
                        {
                             await Application.Current.MainPage.DisplayAlert("Notify?", "Register successfully", "Yes");
                           
                                await Application.Current.MainPage.Navigation.PushModalAsync(new Login());
                            
                        }
                        else
                        {
                            await Application.Current.MainPage.DisplayAlert("Error", "Email already taken!, Please try again", "Ok");
                        }
                    } catch
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "connection eror! Please try again", "Ok");
                    }
                   
                    
                   
                }); 
            }

        }
        public string full_name
        {
            get { return _full_name; }
            set
            {
                _full_name = value;
                OnPropertyChanged();
            }
        }
        public string email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public string phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }
        public string password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public string message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }
        public string address
        {
            get { return _address; }
            set
            {
                _address = value;
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
