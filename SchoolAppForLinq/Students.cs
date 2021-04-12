using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppForLinq
{
    class Students
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return "ID=" + ID + ". Name: " + Name + ". Grade=" + Grade;
        }

    }
}
