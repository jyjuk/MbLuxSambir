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

namespace MbLuxSambir
{
    /// <summary>
    /// Interaction logic for MainUC.xaml
    /// </summary>
    public partial class MainUC : UserControl
    {
        public MainUC()
        {
            InitializeComponent();
        }
        private int count;
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

            textBox.IsEnabled = true;
        }


        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
            textBox.IsEnabled = false;
        }
      
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string s = textBox.Text;
            if ( MainWindow.ChekInt(s) < 0)
                MessageBox.Show("Введи число!!!", "Невірний формат", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
               count = Int32.Parse(s);
               
            }

        }
      
        public  int Count
        {
            get
            {
                return count;
            }
        }
        
    }
}
