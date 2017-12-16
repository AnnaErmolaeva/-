using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Model: INotifyPropertyChanged
    {
        private int _ves { get; set; }
        public int ves
        {
            get { return _ves; }
            set
            {
                _ves = value;
                Notify("ves");
            }
        }
        private int _rost { get; set; }
        public int rost
        {
            get { return _rost; }
            set
            {
                _rost = value;
                Notify("rost");
            }
        }
        private int _vozrast { get; set; }
        public int vozrast
        {
            get { return _vozrast; }
            set
            {
                _vozrast = value;
                Notify("vozrast");
            }
        }
        private Boolean _pol_m { get; set; }
        public Boolean pol_m
        {
            get { return _pol_m; }
            set
            {
                _pol_m = value;
                Notify("pol_m");
            }
        }

        private Boolean _pol_zh { get; set; }
        public Boolean pol_zh
        {
            get { return _pol_zh; }
            set
            {
                _pol_zh = value;
                Notify("pol_zh");
            }
        }
        private int _zhelaemi_ves { get; set; }
        public int zhelaemi_ves
        {
            get { return _zhelaemi_ves; }
            set
            {
                _zhelaemi_ves = value;
                Notify("zhelaemi_ves");
            }
        }
        private DateTime _data { get; set; }
        public DateTime data
        {
            get { return _data; }
            set
            {
                data = value;
                Notify("data");
            }
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
