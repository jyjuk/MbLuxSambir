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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetLabelCol1();
            SetLabelCol2();
            SetLabelCol3();
        }
        Verh vr = new Verh();
        Nuz nz = new Nuz();
        FurnituraPlus fp = new FurnituraPlus();
        MainUC mw = new MainUC();
        private void SetLabelCol1()
        {
            VKut.label.Content = "Верхній кутовий";
            V15.label.Content = "Верхній 15";
            V30.label.Content = "Верхній 30";
            V40.label.Content = "Верхній 40";
            V45.label.Content = "Верхній 45";
            V60.label.Content = "Верхній 60";
            VVut.label.Content = "Верхній Витяжка";
        }
         private void SetLabelCol2()
        {
            NKut.label.Content = "Нижній кутовий";
            N15.label.Content = "Нижній 15";
            N30.label.Content = "Нижній 30";
            N40.label.Content = "Нижній 40";
            N45.label.Content = "Нижній 45";
            N60.label.Content = "Нижній 60";
            NKargo.label.Content = "Cargo";
            NSushka.label.Content = "Сушка";
            NPlyta.label.Content = "Плита";
            NShuflada.label.Content = "Шуфляди";
        }

        private void SetLabelCol3()
        {
            FpDot.label.Content = "Завіс Дотяг";
            FpLift.label.Content = "Ліфт";
            FpR2.label.Content = "Ручка 2";


        }

        //private void SetToVisibleZero()
        //{
        //    VKut.textBox.IsEnabled = false;
        //    V15.textBox.IsEnabled = false;
        //    V30.textBox.IsEnabled = false;
        //    V40.textBox.IsEnabled = false;
        //    V45.textBox.IsEnabled = false;
        //    V60.textBox.IsEnabled = false;
        //    VVut.textBox.IsEnabled = false;
        //    NKut.textBox.IsEnabled = false;
        //    N15.textBox.IsEnabled=false
        //}
        public static int ChekInt(string s)
        {
            int i;
            try
            {
                i = Int32.Parse(s);
                return i;
            }
            catch (FormatException)
            {
                i = -3;
                return i;
            }

        }

        private void btnConfigurator_Click(object sender, RoutedEventArgs e)
        {
            Configurator cf = new Configurator();
            cf.Width = this.Width;
            cf.Height = this.Height;
            cf.Left = this.Left;
            cf.Top = this.Top;
            this.Close();
            cf.Show();
        }

        private void btnFactura_Click(object sender, RoutedEventArgs e)
        {

        }
        private double TopPrice()
        { double priceTop = vr.V15(V15.Count) + vr.V30(V30.Count) + vr.V40(V40.Count) + vr.V60(V60.Count) + vr.VKut(VKut.Count) + vr.VVut(VVut.Count);
            return priceTop;
        }
        private double BottomPrice()
        { double bottomPrice=nz.N15(N15.Count)+nz.N30(N30.Count)+nz.N40(N40.Count)+nz.N45(N45.Count)+nz.N60(N60.Count)+nz.NCargo(NKargo.Count)+nz.NPlyta(NPlyta.Count)+nz.NSushka(NSushka.Count)+nz.NKut(NKut.Count)+nz.NShuflada(NShuflada.Count);
            return bottomPrice;
        }

        private double FurniturePlus()
        {
            double furPrice = fp.Dotjag(FpDot.Count) + fp.Lift(FpLift.Count) + fp.R2(FpR2.Count);
            return furPrice;
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

            double price = TopPrice() + BottomPrice() + FurniturePlus(); ;

            MessageBox.Show((price).ToString());
           

        }

      

       
    }
}
