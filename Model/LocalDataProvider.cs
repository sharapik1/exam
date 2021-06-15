using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Pokipateli> GetPokipatelis()
        {
            return new Pokipateli[] {
            new Pokipateli {Name="Павел", Familia="Пригорков", Age=30, Symmapokipok=680.20, Data=new DateTime(2021,05,21), City="Йошкар-Ола"},
            new Pokipateli {Name="Михаил", Familia="Григорьев", Age=31, Symmapokipok=5747.30, Data=new DateTime(2020,08,21), City="Москва"},
            new Pokipateli {Name ="Петр", Familia = "Михайлович", Age =26, Symmapokipok=2000.60, Data=new DateTime(2021,05,20), City="Уфа"}};
        }
        public IEnumerable<City> GetCities()
        {
            return new City[]
            {
                new City { Title="Йошкар-Ола"},
                new City { Title="Москва"},
                new City { Title="Уфа"},
            };

        }
    }
}
