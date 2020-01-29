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
        ObservableCollection<Entry> Entries = new ObservableCollection<Entry>();

        Random rng = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lbxEntries.ItemsSource = Entries;

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string First = tbxFirst.Text;
            string Last = tbxLast.Text;
            int num1 = int.Parse(tbxNum1.Text);
            int num2 = int.Parse(tbxNum2.Text);
            int num3 = int.Parse(tbxNum3.Text);

            Entry E1 = new Entry(First, Last, num1, num2, num3);

            Entries.Add(E1);
        }

        private void btnWinners_Click(object sender, RoutedEventArgs e)
        {
            int WinNum1 = rng.Next(1,30);
            int WinNum2 = rng.Next(1, 30);
            int WinNum3 = rng.Next(1, 30);

            tblkWinNum1.Text = WinNum1.ToString();
            tblkWinNum2.Text = WinNum2.ToString();
            tblkWinNum3.Text = WinNum3.ToString();

        }
    }
}
