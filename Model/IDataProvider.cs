using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    interface IDataProvider
    {
        IEnumerable<pokipateli> GetPokipatelis();
        IEnumerable<City> GetCities();
    }
   
}
