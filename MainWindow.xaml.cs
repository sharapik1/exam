using System;
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
using WpfApp2.Model;

namespace WpfApp2
{
    public partial class MainWindow : Window, INotifyPropertyChanged

    {
        public string SelectedCity = "";

        public List<City> CityList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private IEnumerable<pokipateli> _PokipateliList = null;
        public IEnumerable<pokipateli> PokipateliList
        {
            get
            {

                var res = _PokipateliList;
                res = res.Where(c => SelectedCity == "Все города" | c.City == SelectedCity);
                if (SearchFilter != "")
                    res = res.Where(c => c.City.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                else res = res.OrderByDescending(c => c.City);
                if (SortAsc) res = res.OrderBy(c => c.Symmapokipok);
                else res = res.OrderByDescending(c => c.Symmapokipok);

                return res;
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
            Globals.dataProvider = new DataProvider("pokipateli.xml");
            PokipateliList = Globals.dataProvider.GetPokipatelis();
            CityList = Globals.dataProvider.GetCities().ToList();
            CityList.Insert(0, new City { Title = "Все города" });

        }
        private void ExitButton_Click(object senter, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("PokipateliList"));
        }

        private void CityFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCity = (CityFilterComboBox.SelectedItem as City).Title;
                Invalidate();
        }

        private string SearchFilter = "";
        private void SearchFilter_KeyUp(object senter, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTexBox.Text;
            Invalidate();
        }
        private bool SortAsc = true;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortAsc = (sender as RadioButton).Tag.ToString() == "1";
            Invalidate();
        }
    }
}
