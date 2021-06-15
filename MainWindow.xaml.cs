﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using WpfApp2;

namespace WpfApp2
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public string SelectedCity = "";
        public List<City> CityList { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private IEnumerable<Pokipateli> _PokipateliList = null;
        
        public IEnumerable<Pokipateli> PokipateliList
        {
            get
            {
                return _PokipateliList
                    .Where(c => (SelectedCity == "Все города" || c.City == SelectedCity));
            }
            set
            {
                _PokipateliList = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            PokipateliList = Globals.dataProvider.GetPokipatelis();
            CityList = Globals.dataProvider.GetCities().ToList();
            CityList.Insert(0, new City { Title = "Все города" });
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("CityList"));
        }
        private void CityFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCity = (CityFilterComboBox.SelectedItem as City).Title;
            Invalidate();
        }
    }
}

