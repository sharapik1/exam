using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<City> GetCities()
        {
            return new City[]
            {
                new City { Title="Йошкар-Ола"},
                new City { Title="Москва"},
                new City { Title="Уфа"},
            };
           
          
            
        }

        public IEnumerable<pokipateli> GetPokipatelis()
        {
            return new pokipateli[] {
            new pokipateli {Name="Павел", Familia="Пригорков", Age=30, Symmapokipok=680.20, Data=new DateTime(2021,05,21), City="Йошкар-Ола"},
            new pokipateli {Name="Михаил", Familia="Григорьев", Age=31, Symmapokipok=5747.30, Data=new DateTime(2020,08,21), City="Москва"},
            new pokipateli {Name ="Петр", Familia = "Михайлович", Age =26, Symmapokipok=2000.60, Data=new DateTime(2021,05,20), City="Уфа"}};
        }   
    }
}
