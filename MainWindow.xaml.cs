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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp2.Model;

namespace WpfApp2
{
    public partial class MainWindow : Window { 
    public IEnumerable<pokipateli> PokipateliList { get; set; }

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        Globals.dataProvider = new LocalDataProvider();
        PokipateliList = Globals.dataProvider.GetPokipatelis();
    }
    private void ExitButton_Click(object senter, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}
}
