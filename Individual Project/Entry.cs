using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public class Entry
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }

        public Entry()
        {

        }
        public Entry(string fname,string lname, int num1, int num2, int num3)
        {
            FirstName = fname;
            LastName = lname;
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Num1}:{Num2}:{Num3}";
        }
    }
}
