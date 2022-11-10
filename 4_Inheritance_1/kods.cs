using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance_1
{
    // Inheritance (miras yada kalıtım) => bir sınıfın başka bir sınıftan türetilmesidir. Miras alan sınıf miras veren sıfının özelliklerini kullanılır. Bu sayede ortak modüller tek bir sınıf altında toplanıp diğer sınıflara devreder. 

    // miras veren sınıfa base class denir. miras alan sınıfada (derived class, child class sub class) gibi isimler verilir. C# dilinde kalıtım operatörü : 'dir. 

    // C# dilinde tekli kalıtım vardır. yani bir sınıf sadece bir sınıftan türeyebilir..
    public class Insan
    {
        public string Adi { get; set; }
        public char Cinsiyet { get; set; }
    }

    // miras alan sınıflar miras veren sınıfların özelliklerini aldıkları gibi kendi özellikleride olabilir
    public class Ogrenci : Insan
    {
    }

    public class Hoca : Insan
    {
        public decimal Maas { get; set; }
    }
    public class Mudur : Insan
    {
    }
}