using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using System.Data.SqlClient;



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
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }



        public static void ssave(string avtor, string novavtor, string namebook, string nameizdatel, int year, int tiraj, string isbn)
        {
            using(SqlConnection cn = new SqlConnection("Server = ANNA-PC; Database= mydatabase; Trusted_Connection = True;"))
            {
                cn.Open();
                string sql = string.Format("INSERT INTO dbo.Table_2 (Avtor, Novavtor, Namebook, Nameizdatel, Year, Tiraj, Isbn) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", avtor, novavtor, namebook, nameizdatel, year, tiraj, isbn);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
            }
        }
        private ICommand _save;
        private ICommand Save
        {
            get
            {
                return _save ?? (_save = new CommandHandler(()=> ssave(avtor, novavtor, namebook, nameizdatel, year, tiraj, isbn), _canExecute ));
            }
        }
        private bool _canExecute;
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
