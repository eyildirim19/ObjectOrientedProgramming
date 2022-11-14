using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Inheritance_2
{
    // Dosya sınıfı base sınıftır..
    // ExcelDosya ve WordDosya sınıfları derived class

    // Örnek 1
    public class Dosya
    {
        public string Path { get; set; }
        public string Uzanti { get; set; }
        public string Adi { get; set; }
    }
    public class ExcelDosya : Dosya
    {
        public void Yazdir()
        {
            Console.WriteLine($"{Adi}.{Uzanti}");
        }
    }
    public class WordDosya : Dosya
    {
        public void Yazdir()
        {
            Console.WriteLine($"{Adi}.{Uzanti}");
        }
    }


    // Örnek 2
    public class Files
    {
        // sınıftan ve sınıftan miras alan sınıflardan erişelebilir üyelerdir...
        public Files(string _Name, string _Extension)
        {
            Name = _Name;
            Extension = _Extension;
        }
        protected string test;
        public string Path { get; set; }
        public string Extension { get; protected set; }
        public string Name { get; protected set; }

        public void Yazdir()
        {
            Console.WriteLine($"{Name}.{Extension}");
        }
    }

    public class ExcelFile : Files
    {
        //public ExcelFile(string _Name, string _Extension) // Constructor
        //{
        //    Name = _Name;
        //    Extension = _Extension;
        //}

        //public void Yazdir()
        //{
        //    Console.WriteLine($"{Name}.{Extension}");
        //}

        public ExcelFile(string _Name, string _Extension)
            : base(_Name, _Extension) // ExcelFile gelen parametreleri, base sınıfa gönderiyoruz...
        {
        }
    }
    public class WordFile : Files
    {
        //public WordFile(string _Name, string _Extension)
        //{
        //    Name = _Name;
        //    Extension = _Extension;
        //}
        //public void Yazdir()
        //{
        //    Console.WriteLine($"{Name}.{Extension}");
        //}
        public WordFile(string _Name, string _Extension)
            : base(_Name, _Extension) // WordFile gelen parametreleri, basae sınıfa gönderiyoruz...
        {
        }
    }
}