using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Project
{
    public class User
    {
        public static int Id = 1;

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string County { get; set; }

        public virtual List<Entry> UserEntry { get; set; }


        //public int Num1 { get; set; }
        //public int Num2 { get; set; }
        //public int Num3 { get; set; }

        public User()
        {

        }
        public User(string fname, string lname, string phoneNo ,string street,string town,string county,int num1, int num2, int num3)
        {
            FirstName = fname;
            LastName = lname;
            PhoneNo = phoneNo;
            Street = street;
            Town = town;
            County = county;

        }

        public User(string fname, string lname, string phoneNo, string street, string town, string county)
        {
            FirstName = fname;
            LastName = lname;
            PhoneNo = phoneNo;
            Street = street;
            Town = town;
            County = county;


        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    public class UserData : DbContext
    {
        public UserData() : base("User Info") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Entry> Entries { get; set; }
    }
}
