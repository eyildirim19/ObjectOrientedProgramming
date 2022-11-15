using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AbstractMember
{
    // abstract member => polymorphism yaklaşımını uygulamak için kullanılırlar...
    public abstract class HayvanlarAlemi
    {
        // abstract üyeler gövdesi olmayan üyelerdir...Genelde gövdeleri derived sınıflar tarafından geliştirileceğinde kullanılır. polimorphism(çok biçimlilik) yaklaşımını uygulamak için kullanılır..
        public abstract string Ses();

        // virtual üyeler =>gövdeleri tanımlanmak zorundadır
        // abstract üyeler => gövdeleri tanımlanmak zorunda değildir(tanımlanamaz);

        // virtual üyeler herde yazılabilir
        // abstract üyeler sadece abstract classlarda tanımlanabilir...

        // virtual üyeler derived sınıflarda ezilebilir (zorunlu değil)
        // abstract üyeler derived sınıflarda ezilmelidir  (zorunlu)
    }
    public class Kedi : HayvanlarAlemi
    {
        public override string Ses()
        {
            // Impelement etmek => base gelen müsait üyelerin tamamlanması veya uygulanmasıdır..
            // throw new NotImplementedException(); // default yazılan bir ifadedir.
            return "Miyaaaaav";
        }
    }
    public class Kus : HayvanlarAlemi
    {
        public override string Ses()
        {
            return "Cik Cik Cik Cik";
        }
    }
}
