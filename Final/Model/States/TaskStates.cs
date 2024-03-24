using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;

namespace Model.States
{

    public enum TaskStates { 
        Назначена = 0,
        Выполняется = 1,
        Приостановлена = 2,
        Завершена = 3
    
    }
}
