using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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
                _data = value;
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

        private bool _canExecute;

        public Page1ViewModel()
        {
            IsSuccess = 1;
            IsSuccess1 = 4;
            _canExecute = true;
           
        }

        


        public static void ssave(int ves, int rost, int vozrast, int IsSuccess, int IsSuccess1, int zhelaemi_ves)
        {
            //REVIEW:А если что-то отвалится? Исключение там...
            using (SqlConnection cn = new SqlConnection("Server = USER-PC\\SQLEXPRESS; Database= MyDataBase; Trusted_Connection = True;"))
            {
                cn.Open();
                string sql = string.Format("INSERT INTO dbo.Table1 (ves, rost, vozrast, aktivnost, pol, zhelaemi_ves) values('{0}','{1}','{2}','{3}','{4}','{5}')", ves, rost, vozrast, IsSuccess, IsSuccess1, zhelaemi_ves);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
        }
        private ICommand _save;
        public ICommand save
        {
            get
            {
                return _save ?? (_save = new CommandHandler(() => ssave(ves, rost, vozrast, IsSuccess, IsSuccess1, zhelaemi_ves), _canExecute));
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
    public class CommandHandler : ICommand
    {
        private Action _action;
        private bool _canExecute;
        public CommandHandler(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            _action();
        }
    }
}
