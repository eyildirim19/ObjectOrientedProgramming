using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation_3
{
    public class Kullanici
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Email
        {
            get
            {
                string first = Adi[0].ToString().ToLower();
                string last = SoyAdi.ToLower();
                return $"{first}{last}@btakademi.com";
            }
        }
    }
}
