using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarManager.Models
{

    public class Person
    {
        public DateTime Time { get; set; }
        public double KW { get; set; }
    }

    public class ViewModel
    {
        public List<Person> Data { get; set; }

        public ViewModel()
        {
            Data = new List<Person>()
        {
            new Person { Time = new DateTime(2011, 6, 10), KW = 170 },
            new Person { Time = new DateTime(2012, 6, 10), KW = 96 },
            new Person { Time = new DateTime(2013, 6, 10), KW = 65 },
            new Person { Time = new DateTime(2014, 6, 10), KW = 182 },
            new Person { Time = new DateTime(2015, 6, 10), KW = 134 }
        };
        }
    }
}
