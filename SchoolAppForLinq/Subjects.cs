using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppForLinq
{
    class Subjects
    {
        public string SubjectName { get; set; }
        public int ID { get; set; }
        public string Teacher { get; set; }
        public override string ToString()
        {
            return "ID=" + ID + ". SubjectName: " + SubjectName + ". Teacher=" + Teacher;
        }
    }
}
