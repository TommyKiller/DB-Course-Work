using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBApp
{
    public class KindOfSport
    {
        public KindOfSport(int id, String name)
        {
            ID = id;
            Name = name;
        }

        public int ID { get; set; }
        public String Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
