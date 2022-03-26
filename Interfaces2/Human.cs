using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal abstract class Human { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override string? ToString()
        {
            return $"Имя:{FirstName} " +
                $"Фамилия:{LastName} " +
                $"Дата рождения:" +
                $"{BirthDate.ToLongDateString()}";
        }
    }
}
