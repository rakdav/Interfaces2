using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal abstract class Employee:Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public override string? ToString()
        {
            return base.ToString()+$"Должность:" +
                $"{Position} Заработная плата:" +
                $"{Salary}";
        }
    }
}
