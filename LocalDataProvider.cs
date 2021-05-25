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
        public IEnumerable<pokipateli> GetPokipatelis()
        {
            return new pokipateli[] {
            new pokipateli{Name="Павел", Familia="Пригорков", Age=30, Symmapokipok=680},
            new pokipateli {Name="Михаил", Familia="Григорьев", Age=31, Symmapokipok=5747},
            new pokipateli {Name="Михаил", Familia="Шарапов", Age=21, Symmapokipok=5757},
            new pokipateli {Name="Иван", Familia="Иванов", Age=31, Symmapokipok=958},
            new pokipateli {Name="Федор", Familia="Соколов", Age=31, Symmapokipok=4000},
            new pokipateli {Name="Дмитрий", Familia="Миронов", Age=31, Symmapokipok=73930},
            new pokipateli {Name="Кристина", Familia="Григорьева", Age=31, Symmapokipok=483020},
            new pokipateli {Name="Анна", Familia="Николаевна", Age=31, Symmapokipok=565629},
            new pokipateli {Name="Михаил", Familia="Григорьев", Age=31, Symmapokipok=59599},
            new pokipateli {Name ="Петр", Familia = "Михайлович", Age =26, Symmapokipok=2000} };
        }   
    }
}
