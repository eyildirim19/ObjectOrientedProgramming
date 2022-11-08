using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructor
{
    public class Ogrenci
    {
        // Constructor (Yapıcılar) => sınıftan instance alındğında tetiklenen metotlardır...eğer bir sınıfta constructor tanımlanmazsa o sınıftan instance alınamaz. bu yüzden sınıfın içerisinde construcotor yazılmadığu sürece gizli constructor kullanılır.eğer constroctor açık bir şekilde yazılırsa gizli constructor iptal edilecektir...

        // constructorlar birer metot gibi davranılar. sadece instance alındığındında otomatik çalışırlar.. bunlar birer metot gibi davrandığı için overload edilebililir. ancak constructorlar özel metotlardır geri dönüş tipi yoktur. İsmi sınıf ismi ile aynı olmalıdır. 

        // constructorlar sınıftan instance alındığında yani new ifadesi ile çağrılıdğında tetiklenir...
        public Ogrenci()
        {
        }
        public Ogrenci(string Adi, string _SoyAdi)
        {
            //this.Adi => sınıfın üyesini
            // Adi => parametreyi...
            this.adi = Adi;
            SoyAdi = _SoyAdi;
        }
        private string adi;
        public string Adi
        {
            get
            {
                return adi;
            }
            set
            {
                adi = value.ToUpper();
            }
        }
        public string SoyAdi { get; set; }
        // Genel kural => field isimleri küçük harf ile, property isimleri büyük harf ile yapılır. field ve propertyler aynı isme sahip olarak baş harflerinden ayırt edilir...
    }
}