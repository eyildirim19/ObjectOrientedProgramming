using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_3
{
    public  interface IPersonel
    {
        void MaasOde();
    }
    public class Insan
    {
        public string Adi { get; set; }
    }
    public class Egitmen : Insan, IPersonel
    {
        public void MaasOde()
        {
            Console.WriteLine("Eğitmenlerin Maaşları Ödendi");
        }
    }
    public class EgitimDanismani : Insan, IPersonel
    {
        public void MaasOde()
        {
            Console.WriteLine("Eğitim Danımlmanlarının Maaşları Ödendi");
        }
    }
    public class Ogrenci : Insan
    {
    }
}