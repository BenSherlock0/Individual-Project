using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public class Entry
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Num3 { get; set; }
        public DateTime Date { get; set; }

        //public int[] Numbers { get; set; }

        public Entry(int num1,int num2, int num3, DateTime date)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
            Date = date;
        }

        public override string ToString()
        {
            //return $"{FirstName} {LastName} {UserEntry.Num1}:{UserEntry.Num2}:{UserEntry.Num3}";
            return $"{Num1}:{Num2}:{Num3}:{Date}";
        }


    }
}
