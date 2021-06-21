using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WpfApp2.Model
{
    public class XMLDataProvider : IDataProvider
    {
        private pokipateli[] pokipateliArray;

        public XMLDataProvider(String fileName)
        {
           

            XmlSerializer formatter = new XmlSerializer(typeof(pokipateli[]));
            using (FileStream PokipateliList = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                pokipateliArray = (pokipateli[])formatter.Deserialize(PokipateliList);
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
            return pokipateliArray;
        }
    }
}
