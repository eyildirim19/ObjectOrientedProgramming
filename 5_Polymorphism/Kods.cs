using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Polymorphism
{
    /*
           Polymorphism (Çok Biçimlilik) => Base classlardan gelen üyelerin Derived Classlarda farklı davranışlar sergilemesini sağlama yaklaşımıdır..
    */

    public class HayvanlarAlemi
    {
        public string Tur { get; set; }
 // virtual  => üyenin alt sınıflardan tarafından ezilebilir olduğu anlamına gelir..
        // virtual üyeler ovveride ifadesi ile ezilir...
        // virtual => üyenin miras alan sınıf tarafından gövdesinin değiştirilebilir hale gelmesini sağlar. runtime'da derived sınıf base üzrinden çağrılırsa üye base'deki gibi değil derived sınıftaki gibi davranır
        public virtual string Ses()
        {
            return "adadsadada";
        }
    }
    public class Kedi : HayvanlarAlemi
    {
        // override => baseden gelen virtual üyeyi ezmek için kullanılır
        public override string Ses()
        {
            return "Miyav Miyav";
        }
    }
    public class Kus : HayvanlarAlemi
    {
        public override string Ses()
        {
            return "Cik Cik";
        }
    }
    public class Kopek : HayvanlarAlemi
    {
        public override string Ses()
        {
            return "Hav Hav";
        }
    }
}
