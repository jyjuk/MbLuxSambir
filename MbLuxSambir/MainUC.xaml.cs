using System;
using System.Windows;
using System.Windows.Controls;

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
