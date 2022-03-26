using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal interface IManager
    {
        List<IWorker> ListOfWorkers { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }
}
