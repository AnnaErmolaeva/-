using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Window2ViewModel : INotifyPropertyChanged
    {

        private double _norma { get; set; }
        public double norma
        {
            get { return _norma; }
            set
            {
                _norma = value;
                Notify("ves");
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
