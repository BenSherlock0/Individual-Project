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
    }
}
