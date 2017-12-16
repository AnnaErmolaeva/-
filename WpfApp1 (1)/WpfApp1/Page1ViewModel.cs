using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WpfApp1
{
    public class Page1ViewModel : INotifyPropertyChanged
    {

        private int _ves;
        public int ves
        {
            get { return _ves; }
            set
            {
                _ves = value;
                Notify("ves");
            }
        }
        private int _rost;
        public int rost
        {
            get { return _rost; }
            set
            {
                _rost = value;
                Notify("rost");
            }
        }
        private int _vozrast;
        public int vozrast
        {
            get { return _vozrast; }
            set
            {
                _vozrast = value;
                Notify("vozrast");
            }
        }
        private Boolean _pol_m;
        public Boolean pol_m
        {
            get { return _pol_m; }
            set
            {
                _pol_m = value;
                Notify("pol_m");
            }
        }

        private Boolean _pol_zh;
        public Boolean pol_zh
        {
            get { return _pol_zh; }
            set
            {
                _pol_zh = value;
                Notify("pol_zh");
            }
        }
        private int _zhelaemi_ves;
        public int zhelaemi_ves
        {
            get { return _zhelaemi_ves; }
            set
            {
                _zhelaemi_ves = value;
                Notify("zhelaemi_ves");
            }
        }
        private DateTime _data;
        public DateTime data
        {
            get { return _data; }
            set
            {
                data = value;
                Notify("data");
            }
        }

       
        private int _isSuccess;
        public int IsSuccess
        { get { return _isSuccess; }
            set
            { _isSuccess = value;
                Notify("IsSuccess");
            }
        }
        private int _isSuccess1;
        public int IsSuccess1
        {
            get { return _isSuccess1; }
            set
            {
                _isSuccess1 = value;
                Notify("IsSuccess1");
            }
        }

        public Page1ViewModel()
        {
            IsSuccess = 1;
            IsSuccess1 = 4;
           
        }




        public event PropertyChangedEventHandler PropertyChanged;
            private void Notify(string propName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propName));
                }
            }
        

    }
}
