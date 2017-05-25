using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace WpfApplication1
{
    public class MainWindowViewModel
    {
        public string avtor1 { get; set; }
        public string avtor2 { get; set; }
        public string novavtor { get; set; }
        public string namebook { get; set; }
        public string nameizdatel { get; set; }
        public string nameyear { get; set; }
        public int tiraj { get; set; }
        public string isbn { get; set; }
        public ICommand save { get; set; }
        public ICommand otmena { get; set; }




    }
}
