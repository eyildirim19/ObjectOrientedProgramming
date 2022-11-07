using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation_2
{

    /*
     
        property => sınıfın üyelerini (field) işaret eden üyelerdir..fieldlara değer atamak ve dğer okumak için kullanılır. genel anlamda kapsülleme yapmak için kullanılır. kapsüllemeye müsait bir yapıdır. set bloğı ve get bloğu metot görevi görür..


        eğer property AdSoyAd örneğindeki gibi kullanılırsa yani get ve set blokları açılmazsa bu property field gibi kullanılır. yani propertylerin gövdeleri ezilmezse (geti veya seti açılmazsa) arka tarafta bizim göremediğimiz gizli bir field vardır....

        // bundan sonraki süreçte field yerine property kullanılacaktır... field sadece kapsülleme yapılacağı zaman kullanılır... 
           public tip propertyName {get;set;}

    NOT : SET TEKİ VALUE PROPERTY TİPİNDEDİR. GET'TE DÖNÜLECEK DEĞERDEYİNE PROPERTY TİPİNDEDİR..
     */

    public class Ogrenci
    {
        private string kursAdi = "Bt Akademi";
        public string KursAdi
        {
            get
            {
                return kursAdi;
            }
        }
        private int yas;
        public int Yas
        {

            get // geriye değer döndüren metot
            {
                return yas;
            }
            set// parametre alan void metot. buradaki parametre value keywordü ile kullanılır. value'nın tipi property tipidir..
            {
                if (value < 18)
                    yas = 18;
                else
                    yas = value;
            }
        }
        // burada encapsulation yok... 
        public string AdSoyAd { get; set; }   // yukarıdaki yapı aşaıdaki yapıya tercih edilmelidir. (sasedce encapsulationy yapılmadığı durumlarda)
        //private string adsoyad;
        //public string AdSoyAd
        //{
        //    get
        //    {
        //        return adsoyad;
        //    }
        //    set
        //    {
        //        adsoyad = value;
        //    }
        //}
    }
}
