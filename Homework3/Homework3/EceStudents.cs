using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework3.EnumsAndStructs;

namespace Homework3
{
    class EceStudents
    {

        private List<ECE> _eceStudents = new List<ECE>();

        public void add(ECE eceStudent)
        {
            _eceStudents.Add(eceStudent);
        }

    }
}
