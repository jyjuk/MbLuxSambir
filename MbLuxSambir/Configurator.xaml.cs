﻿using System;
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
using System.Windows.Shapes;
using MbLuxSambir.Models;
using MbLuxSambir.ViewModels;
using MbLuxSambir.BusinessLogic;
using System.Collections.ObjectModel;

namespace MbLuxSambir
{
    /// <summary>
    /// Interaction logic for Configurator.xaml
    /// </summary>
    public partial class Configurator : Window
    {
        public Configurator()
        {
            InitializeComponent();
            //SetLabel();
            //LoadPrice();

            //var mainViewModel = new MainViewModel();

            //mainViewModel.TumbochkaNyzes = new ObservableCollection<TumbochkaNyz>();
            //mainViewModel.TumbochkaNyzes.Add(new TumbochkaNyz("Кутова"));



            var configurationModel = new ConfiguratorViewModel();
            configurationModel.Pricess = new ObservableCollection<Component>();
            configurationModel.Pricess.Add(new Component(340,"Плита"));
            
            configurationModel.Pricess.Add(new Component(170,"DVP"));
            configurationModel.Pricess.Add(new Component(5,"Нога кухонна"));
            configurationModel.Pricess.Add(new Component(1,"Шурупи"));
            configurationModel.Pricess.Add(new Component(3,"Конфірмат"));
            configurationModel.Pricess.Add(new Component(1,"Полко тримач"));
            configurationModel.Pricess.Add(new Component(2,"Стяжка міжсекційна"));
            configurationModel.Pricess.Add(new Component(550,"Фасад"));
            configurationModel.Pricess.Add(new Component(24,"Ручка"));
            configurationModel.Pricess.Add(new Component(40,"Ручка2"));
            configurationModel.Pricess.Add(new Component(5,"Завіс"));
            configurationModel.Pricess.Add(new Component(47,"Завіс дотяг"));
            configurationModel.Pricess.Add(new Component(54,"Направляюча"));
            configurationModel.Pricess.Add(new Component(146,"Стільниця"));
            configurationModel.Pricess.Add(new Component(8,"PCV"));
            configurationModel.Pricess.Add(new Component(3,"Клей PCV"));
            configurationModel.Pricess.Add(new Component(86,"Cargo"));
            configurationModel.Pricess.Add(new Component(34,"Карніз"));
            configurationModel.Pricess.Add(new Component(20,"Ліфт"));
            configurationModel.Pricess.Add(new Component(60,"Сушка"));
            configurationModel.Pricess.Add(new Component(4,"Петлі монтажні"));

            DataContext = configurationModel;       

               
            
            
            


        }


       
        //private void SetLabel()
        //{
        //    PriceCargo.label.Content = "Cargo";
        //    PriceDvp.label.Content = "Dvp";
        //    PriceFasad.label.Content = "Fasad";
        //    PriceKarniz.label.Content = "Karniz";
        //    PriceKlejPcv.label.Content = "Cina Kleja";
        //    PriceKonfirmat.label.Content = "Konfirmat";
        //    PriceLift.label.Content = "Lift";
        //    PriceNaprav.label.Content = "Napravlaucha";
        //    PriceNogaKuhona.label.Content = "Noga Kuhona";
        //    PricePcv.label.Content = "Pcv";
        //    PricePluta.label.Content = "Pluta";
        //    PricePolkotrymach.label.Content = "Polkotrymach";
        //    PriceRuchka1.label.Content = "Ruchka 1";
        //    PriceRuchka2.label.Content = "Ruchka 2";
        //    PriceShurup.label.Content = "Shurup";
        //    PriceStolesh.label.Content = "Stoleshnja";
        //    PriceStyazka.label.Content = "Stazka";
        //    PriceSushka.label.Content = "Suszka";
        //    PriceVuha.label.Content = "Vuha";
        //    PriceZavis.label.Content = "Zavis";
        //    PriceZavisDot.label.Content = "Zavis Dotjag";


        //}

        //private void LoadPrice()
        //{
        //    PriceCargo.textbox.Text = (Properties.Settings.Default.PriceCargo).ToString();
        //    PriceDvp.textbox.Text = (Properties.Settings.Default.PriceDvp).ToString();
        //    PriceFasad.textbox.Text = (Properties.Settings.Default.PriceFasad).ToString();
        //    PriceKarniz.textbox.Text = (Properties.Settings.Default.PriceKarniz).ToString();
        //    PriceKlejPcv.textbox.Text = (Properties.Settings.Default.PriceKlejPcv).ToString();
        //    PriceKonfirmat.textbox.Text = (Properties.Settings.Default.PriceKonfirmat).ToString();
        //    PriceLift.textbox.Text = (Properties.Settings.Default.PriceLift).ToString();
        //    PriceNaprav.textbox.Text = (Properties.Settings.Default.PriceNaprav).ToString();
        //    PriceNogaKuhona.textbox.Text = (Properties.Settings.Default.PriceNogaKuhona).ToString();
        //    PricePcv.textbox.Text = (Properties.Settings.Default.PricePcv).ToString();
        //    PricePluta.textbox.Text = (Properties.Settings.Default.PricePluta).ToString();
        //    PricePolkotrymach.textbox.Text = (Properties.Settings.Default.PricePolkotrymach).ToString();
        //    PriceRuchka1.textbox.Text = (Properties.Settings.Default.PriceRuchka1).ToString();
        //    PriceRuchka2.textbox.Text = (Properties.Settings.Default.PriceRuchka2).ToString();
        //    PriceShurup.textbox.Text = (Properties.Settings.Default.PriceShurup).ToString();
        //    PriceStolesh.textbox.Text = (Properties.Settings.Default.PriceStolesh).ToString();
        //    PriceStyazka.textbox.Text = (Properties.Settings.Default.PriceStyazka).ToString();
        //    PriceSushka.textbox.Text = (Properties.Settings.Default.PriceSushka).ToString();
        //    PriceVuha.textbox.Text = (Properties.Settings.Default.PriceVuha).ToString();
        //    PriceZavis.textbox.Text = (Properties.Settings.Default.PriceZavis).ToString();
        //    PriceZavisDot.textbox.Text = (Properties.Settings.Default.PriceZavisDot).ToString();
        //}

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Left = this.Left;
            mw.Top = this.Top;
            this.Close();
            mw.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //Properties.Settings.Default.PriceCargo = Double.Parse(PriceCargo.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceDvp = Double.Parse(PriceDvp.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceFasad = Double.Parse(PriceFasad.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceKarniz = Double.Parse(PriceKarniz.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceKlejPcv = Double.Parse(PriceKlejPcv.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceKonfirmat = Double.Parse(PriceKonfirmat.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceLift = Double.Parse(PriceLift.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceNaprav = Double.Parse(PriceNaprav.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceNogaKuhona = Double.Parse(PriceNogaKuhona.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PricePcv = Double.Parse(PricePcv.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PricePluta = Double.Parse(PricePluta.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PricePolkotrymach = Double.Parse(PricePolkotrymach.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceRuchka1 = Double.Parse(PriceRuchka1.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceRuchka2 = Double.Parse(PriceRuchka2.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceShurup = Double.Parse(PriceShurup.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceStolesh = Double.Parse(PriceStolesh.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceStyazka = Double.Parse(PriceStyazka.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceSushka = Double.Parse(PriceSushka.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceVuha = Double.Parse(PriceVuha.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceZavis = Double.Parse(PriceZavis.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.PriceZavisDot = Double.Parse(PriceZavisDot.textbox.Text.Replace('.', ','));
            //Properties.Settings.Default.Save();
        }
    }
}
