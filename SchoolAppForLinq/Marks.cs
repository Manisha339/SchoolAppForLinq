using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAppForLinq
{
    class Marks
    {
        public int Maths { get; set; }
        public int Social { get; set; }
        public int Science { get; set; }
        public int English { get; set; }
        public int Computers { get; set; }

        public int ID { get; set; }

        public override string ToString()
        {
            return "ID=" + ID + ". Maths: " + Maths + ". Social: " + Social + ". Science: " + Science + ". English: " + English + ". Computers: " + Computers ;
        }
    }
}
