using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    [DataContract]
    public  class pokipateli
    {
        private DateTime privateDate;
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Familia { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public double Symmapokipok { get; set; }

       
        [DataMember]
        public string City { get; set; }
        [DataMember(Name = "Date")]
        public string StringDate
        {
            get
            {

                return privateDate.ToString("yyyy-MM-dd");
            }
            set
            {
                privateDate = new DateTime(
                    Convert.ToInt32(value.Substring(0, 4)),
                    Convert.ToInt32(value.Substring(5, 2)),
                    Convert.ToInt32(value.Substring(8, 2))
                    );
            }

        }
        [IgnoreDataMember]
        public DateTime Date
        {
            get
            {
                return privateDate;
            }
            set
            {
                privateDate = value;
            }
        }
        public string DateString
        {
            get
            {
                return Date.ToShortDateString();
            }
        }


    }
}
