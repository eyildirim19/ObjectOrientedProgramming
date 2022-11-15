using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AbstractClass
{
    // abstract class => soyut sınıf. Abstraction yaklaşımını uygulamak için kullanılır. Bu tür sınıflar sadece miras vermek için tanımlanır. 

    // absract classlardan instance alınamaz..

    // Miras veren sınıflar genelde ortak özellikler barındırmak için tanımlanır. miras alan sınıflarda sınıfla özgü üyeler tanımlanır. bu yüzden nesneler miras alan sınıflar tarafından oluşturulur. 
    public abstract class Insan
    {
        public string AdSoyAd { get; set; }
        public char Cinsyet { get; set; }
    }

    public class Ogrenci : Insan
    {
        public float Not { get; set; }
    }

    public class Hoca : Insan
    {
        public decimal Maas { get; set; }
    }
}
