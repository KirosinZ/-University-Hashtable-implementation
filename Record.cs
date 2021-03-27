using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRIALG_HASH
{
    public class Record
    {
        public int PersonnelNumber { get; }
        public string FIO { get; }
        public decimal Salary { get; }

        public Record(int number, string fio, decimal salary)
        {
            PersonnelNumber = number;
            FIO = fio;
            Salary = salary;
        }
    }
}
