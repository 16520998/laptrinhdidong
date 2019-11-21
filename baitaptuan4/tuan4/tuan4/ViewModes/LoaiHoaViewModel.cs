using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using tuan4.Interface;
using tuan4.Models;
using tuan4.Respository;
using Xamarin.Forms;

namespace tuan4.ViewModes
{
    public class LoaiHoaViewModel : INotifyPropertyChanged
    {
        private LoaiHoa loaihoa;
        public ILoaiHoaRespository loaiHoaRespository;
        public ICommand AddLoaiHoa { get; private set; }
        public ICommand UpdateLoaiHoa { get; private set; }
        public ICommand DeleteLoaiHoa { get; private set; }
        ObservableCollection<LoaiHoa> loaihoalist;
        public ObservableCollection<LoaiHoa> Loaihoalist
        {
            get { return loaihoalist; }
            set
            {
                loaihoalist = value;
                RaisePropertyChanged("Loaihoalist");
            }
        }
        void Loadloaihoa()
        {
            Loaihoalist = loaiHoaRespository.GetLoaiHoas();
        }
        public LoaiHoa Loaihoa
        {
            get { return loaihoa; }
            set { loaihoa = value;
                RaisePropertyChanged("Loaihoa");
                ((Command)UpdateLoaiHoa).ChangeCanExecute();
                ((Command)DeleteLoaiHoa).ChangeCanExecute();
            }
        }
        private void Insert()
        {
            loaiHoaRespository.Insert(loaihoa);
            Loadloaihoa();
        }
        private void Update()
        {
            loaiHoaRespository.Update(loaihoa);
            Loadloaihoa();
        }
        private void Delete()
        {
            loaiHoaRespository.Delete(loaihoa);
            Loadloaihoa();
        }
        public LoaiHoaViewModel()
        {
            loaiHoaRespository = new LoaiHoaRepository();
            Loadloaihoa();
            AddLoaiHoa = new Command(Insert);
            UpdateLoaiHoa = new Command(Update, CanExe);
            DeleteLoaiHoa = new Command(Delete, CanExe);
            loaihoa = new LoaiHoa();
        }

        private bool CanExe()
        {
            if (Loaihoa == null || Loaihoa.Maloai == 0)
                return false;
            else
                return true;
        }
        public int Maloai
        {
            get { return loaihoa.Maloai; }
            set { loaihoa.Maloai = value;
                RaisePropertyChanged("Maloai");
            }
        }
        public string Tenloai
        {
            get { return loaihoa.Tenloai; }
            set { loaihoa.Tenloai = value;
                RaisePropertyChanged("Tenloai");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
