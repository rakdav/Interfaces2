using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Seller : Employee, IWorker
    {
        private bool isWorking=true;
        public bool IsWorking 
        { 
            get { return isWorking; } 
        }
        public string Work()
        {
            return "Продаю товар";
        }
    }
}
