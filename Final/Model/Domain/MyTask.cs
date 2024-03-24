using System;
using System.Collections.Generic;
using System.ComponentModel;
using Model.States;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain 
{
    public class MyTask : IDomainObject, INotifyPropertyChanged
    {
        public MyTask() { }
        public int Id { get; set; }

        private string _title;
        public string Title { get { return _title;  }
            set { _title = value;
                OnPropertyChanged();
            } }
        public string Description { get; set; }
        public string? Executers { get; set; }
        public DateTime? DateReg { get; set; }
        public TaskStates? State { get; set; }
        public int? PlanCost { get; set; }  
        public int? FactTimeExecute { get; set; }
        public DateTime? DateEnd { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public override string ToString() => Title;
        
    }
}
