using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    public class DataProvider : IDataProvider
    {
        private List<pokipateli> PokipateliList = new List<pokipateli>();
        public DataProvider(String fileName)
        {
            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData)
                {
                    //метод ReadFields разбивает исходную строку на массив строк
                    string[] fields = parser.ReadFields();
                    PokipateliList.Add(
                        new pokipateli
                        {
                            Name = fields[0],
                            Familia = fields[1],
                            Age = int.Parse(fields[2]),
                            Symmapokipok = Double.Parse(fields[3]),
                            Data = DateTime.Parse(fields[4]),
                            //Data = DateTime.ParseExact(fields[4], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                            City = fields[5]
                        }
                        );

                }
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
