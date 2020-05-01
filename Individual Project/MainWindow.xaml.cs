using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Individual_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<User> Users = new ObservableCollection<User>();
        ObservableCollection<Entry> Entries = new ObservableCollection<Entry>();
        ObservableCollection<Entry> Winners = new ObservableCollection<Entry>();

        //Tried make a database but the it wasn't working for me and kept freezing

        Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            User U1 = new User("Ben", "Casey", "0867528511", "Main Street", "Gurteen", "Sligo");
            User U2 = new User("Patrick", "Kelly", "0845674321", "Main Street", "Ballaghaderreen", "Roscommon");
            Users.Add(U1);
            Users.Add(U2);

            lbxEntries.ItemsSource = Users;
            lbxWinners.ItemsSource = Winners;
            combxUser.ItemsSource = Users;
            lbxTickets.ItemsSource = Entries;


        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string First = tbxFirst.Text;
                string Last = tbxLast.Text;
                string phone = tbxTelephone.Text;
                string street = tbxStreet.Text;
                string town = tbxTown.Text;
                string city = tbxTown.Text;
                string county = tbxCounty.Text;

                User U1 = new User(First, Last, phone, street, town, county);
                Users.Add(U1);


            }
            catch
            {
                
            }
        }

        private void btnWinners_Click(object sender, RoutedEventArgs e)
        {
            int WinNum1;
            int WinNum2;
            int WinNum3;

            WinNum1 = rng.Next(1, 31);
            do
            {
                WinNum2 = rng.Next(1, 31);
            } while (WinNum2 == WinNum1);

            do
            {
                WinNum3 = rng.Next(1, 31);
            } while (WinNum3 == WinNum1 || WinNum3 == WinNum2);


            tblkWinNum1.Text = WinNum1.ToString();
            tblkWinNum2.Text = WinNum2.ToString();
            tblkWinNum3.Text = WinNum3.ToString();

            foreach(Entry entry in Entries)
            {
                if(entry.Num1 == WinNum1 || entry.Num1 == WinNum2 || entry.Num1 == WinNum3)
                {
                    if (entry.Num2 == WinNum1 || entry.Num2 == WinNum2 || entry.Num2 == WinNum3)
                    {
                        if (entry.Num3 == WinNum1 || entry.Num3 == WinNum2 || entry.Num3 == WinNum3)
                        {
                            Winners.Add(entry);
                        }
                    }
                }
            }
        }

        private void LbxEntries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User selectedentry = lbxEntries.SelectedItem as User;

            txtblkDetails.Text = $"First Name: {selectedentry.FirstName}  \nLast Name: {selectedentry.LastName} \n" +
                $"Phone No: {selectedentry.PhoneNo} \nStreet: {selectedentry.Street} \nTown: {selectedentry.Town} \nCounty: {selectedentry.County}"; //Show details
        }

        private void btnNums_Click(object sender, RoutedEventArgs e)
        {
            string num;
            bool copy = false;

            try
            {
                num = tbxNum1.Text;
                int num1 = Convert.ToInt32(num);

                num = tbxNum2.Text;
                int num2 = Convert.ToInt32(num);

                num = tbxNum3.Text;
                int num3 = Convert.ToInt32(num);

                copy = findCopy(num1, num2, num3);


                if (copy == false)
                {
                    Entry E1 = new Entry(num1, num2, num3, DateTime.Now);
                    Entries.Add(E1);
                }
                else
                {
                    MessageBox.Show("No duplicates please.");
                }
            }
            catch
            {
                MessageBox.Show("Please enter number values into the number boxes");
            }
            

        }

        public static bool findCopy(int num1,int num2,int num3)
        {
            bool copy = false;

            if (num1 == num2 || num1 == num3 || num3 == num2)
            {
                copy = true;
            }

            return copy;
        }
    }
}
