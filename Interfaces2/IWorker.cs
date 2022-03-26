using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal interface IWorker
    {
        bool IsWorking { get; }
        string Work();
    }
}
