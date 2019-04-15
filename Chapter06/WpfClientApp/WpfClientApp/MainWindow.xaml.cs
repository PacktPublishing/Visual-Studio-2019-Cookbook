using System;
using System.Collections.Generic;
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
using System.Configuration;
using System.Data.SqlClient;

namespace WpfClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfClientApp.wpfDBDataSet wpfDBDataSet = ((WpfClientApp.wpfDBDataSet)(this.FindResource("wpfDBDataSet")));
            // Load data into the table Student. You can modify this code as needed.
            WpfClientApp.wpfDBDataSetTableAdapters.StudentTableAdapter wpfDBDataSetStudentTableAdapter = new WpfClientApp.wpfDBDataSetTableAdapters.StudentTableAdapter();
            wpfDBDataSetStudentTableAdapter.Fill(wpfDBDataSet.Student);
            System.Windows.Data.CollectionViewSource studentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource")));
            studentViewSource.View.MoveCurrentToFirst();
        }

        
    }
}
