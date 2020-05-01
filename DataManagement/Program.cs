using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Individual_Project;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData db = new UserData();

            using (db)
            {
                User U1 = new User() { UserID = 1, FirstName = "Jack", LastName = "Smith", PhoneNo = "093 123 4321", Street = "Main Road", Town = "Sligo", County = "Sligo" };
                Entry E1 = new Entry() { TicketID = 1, Num1 = 1, Num2 = 5, Num3 = 10, UserID = 1 };

                User U2 = new User() { UserID = 2, FirstName = "Andy", LastName = "Jackson", PhoneNo = "093 987 7890", Street = "Side Road", Town = "Ballymote", County = "Sligo" };
                Entry E2 = new Entry() { TicketID = 2, Num1 = 10, Num2 = 15, Num3 = 22, UserID= 2 };
                Entry E3 = new Entry() { TicketID = 3, Num1 = 5, Num2 = 21, Num3 = 28, UserID = 2 };

                db.Users.Add(U1);
                db.Users.Add(U2);

                db.Entries.Add(E1);
                db.Entries.Add(E2);
                db.Entries.Add(E3);

                db.SaveChanges();

                Console.WriteLine("Done");

            }
        }
    }
}
