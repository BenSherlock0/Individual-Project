using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string County { get; set; }

        public Entry UserEntry { get; set; }


        //public int Num1 { get; set; }
        //public int Num2 { get; set; }
        //public int Num3 { get; set; }

        public User()
        {

        }
        public User(string fname,string lname, int num1, int num2, int num3)
        {
            FirstName = fname;
            LastName = lname;
            //Num1 = num1;
            //Num2 = num2;
            //Num3 = num3;
        }

        public User(string fname, string lname, string phoneNo ,string street,string town,string county,int num1, int num2, int num3)
        {
            FirstName = fname;
            LastName = lname;
            PhoneNo = phoneNo;
            Street = street;
            Town = town;
            County = county;

            UserEntry.Num1 = num1;
            UserEntry.Num2 = num2;
            UserEntry.Num3 = num3;

            //Num1 = num1;
            //Num2 = num2;
            //Num3 = num3;
        }

        public User(string fname, string lname, string phoneNo, string street, string town, string county)
        {
            FirstName = fname;
            LastName = lname;
            PhoneNo = phoneNo;
            Street = street;
            Town = town;
            County = county;

            //UserEntry.Num1 = num1;
            //UserEntry.Num2 = num2;
            //UserEntry.Num3 = num3;

            //Num1 = num1;
            //Num2 = num2;
            //Num3 = num3;
        }

        public override string ToString()
        {
            //return $"{FirstName} {LastName} {UserEntry.Num1}:{UserEntry.Num2}:{UserEntry.Num3}";
            return $"{FirstName} {LastName}";
        }
    }
}
