using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;


namespace WpfApplication1
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        public string avtor
        {
            get { return _author; }
            set
            {
                _author = value;
                Notify(nameof(avtor));
            }
        }
       
        public string novavtor { get; set; }
        public string namebook { get; set; }
        public string nameizdatel { get; set; }
       
        public int year
        {
            get { return _year; }
            set
            {
                if (value <= DateTime.Now.Year)
                {
                    _year = value;
                    Notify(nameof(year));
                }
            }
        }
        
        public int tiraj
        {
            get { return _tiraj; }
            set
            {
                if (value > 0)
                {
                    _tiraj = value;
                    Notify(nameof(tiraj));
                }
                else
                {
                    
                }
            }
        }
        public string isbn { get; set; }
        public ICommand save { get; set; }
        public ICommand otmena { get; set; }

        private int _tiraj = 1;
        private int _year = DateTime.Now.Year;
        private string _author;


        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }

}
