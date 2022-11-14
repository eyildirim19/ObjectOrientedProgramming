using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polymorphism_2
{
    public class Insan
    {
        public virtual void Dusunce()
        {
            Console.WriteLine(".....");
        }
    }

    public class Ogrenci : Insan
    {
        public override void Dusunce()
        {
            // base.Dusunce();
            Console.WriteLine("Hoca anlatamıyor");
        }
    }

    public class Hoca : Insan
    {
        public override void Dusunce()
        {
            //base.Dusunce();
            Console.WriteLine("Öğrenciler anlamıyor");
        }
    }

}
