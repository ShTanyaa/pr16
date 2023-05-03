using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt15
{
    class Oranization
    {
        private string street;
        private string city;
        private string country;
        private int num_house;

        public Oranization(string country,string city,string street,int num_house)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.num_house = num_house;
        }
        public int Num_house { get { return num_house; } set { num_house = value; } }
    }
}
