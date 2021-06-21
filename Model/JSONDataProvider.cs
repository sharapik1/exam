using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
 
   

    public class JSONDataProvider : IDataProvider
    {
        private pokipateli[] PokipateliList;
        //private List<pokipateli> PokipateliList = new List<pokipateli>();

        public JSONDataProvider(String fileName)
        {
            var Serializer = new DataContractJsonSerializer(typeof(pokipateli[]));
            using (var sr =  new StreamReader(fileName))
            {
                PokipateliList = (pokipateli[])Serializer.ReadObject(sr.BaseStream);
            }
        }

        public IEnumerable<City> GetCities()
        {
            return new City[]
            {
                new City { Title="Йошкар-Ола"},
                new City { Title="Москва"},
                new City { Title="Уфа"}
            };
        }

        public IEnumerable<pokipateli> GetPokipatelis()
        {
            return PokipateliList;
        }
    }
}
