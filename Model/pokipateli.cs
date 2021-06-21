﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    [Serializable]
    public class pokipateli
    {
        public string Name { get; set; }
        public string Familia { get; set; }
        public int Age { get; set; }
        public double Symmapokipok { get; set; }
        public DateTime Data { get; set; }
        public string City { get; set; }

        public string DateString
        {
            get
            {
                return Data.ToShortDateString();
            }
        }
        
    }
}
