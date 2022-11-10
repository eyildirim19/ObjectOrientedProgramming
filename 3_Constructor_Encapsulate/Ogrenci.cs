using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constructor_Encapsulate
{
    public class Ogrenci
    {
        // readonly üyelere sadece constructorlarda değer atanabilir
        public Ogrenci(float v, float f, string a)
        {
            Vize = v;
            Final = f;
            Ortalama = v * 0.4f + f * 0.6f;
        }
        public readonly float Vize;
        public float Final { get; }
        // fieldlara class seviyesinde erişilemez..Class seviyesinden tanımlanan üyelere erişelemez. üyelere sadece alt scopelardan erişilebilir....
      //  public float Ortalama = Vize * 04f + Final * 0.6f;

        // propertyler'de readonly kullanılmaz. readonly olacak eğer property'Nin set'ini siler get'i bırakırsınız
        public float Ortalama { get; }
        // readonly property
        public string HarfNotu
        {
            get
            {
                // swithc expression ile yazdık...
                // => lambda ifadesi (ileride detaylı konuşacağız)
                return Ortalama switch
                {
                    >= 80 and < 100 => "AA",
                    >= 70 and < 80 => "BA",
                    >= 60 and < 70 => "BB",
                    >= 50 and < 70 => "CC",
                    >= 40 and < 50 => "DC",
                    < 40 => "FF"
                };
            }
        }

        public Ogrenci()
        {
            Console.WriteLine("instance alındı");
        }

        ~Ogrenci() // yıkıcı metot
        {
            Console.WriteLine("instance silindi...");
        }
    }

}