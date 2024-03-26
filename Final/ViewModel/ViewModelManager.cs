using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ViewModelManager
    {
        private ViewModelManager() { }
        public static ViewModelManager _instance = new ViewModelManager ();

        public static ViewModelManager Instance { get { return _instance; } }

        public delegate void 

    }
}
