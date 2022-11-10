namespace _4_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Berat";

            Hoca hc = new Hoca();
            hc.Adi = "Ekrem";
            hc.Maas = 500;

            Mudur mü = new Mudur();
            mü.Adi = "İsmail";

            Test(ogr);
            Test(hc);
            Test(mü);


            Console.WriteLine("Hello, World!");
        }

        public static void Test(Insan p)
        {
            Console.WriteLine(p.Adi);
        }

        //public static void Test(Ogrenci p)
        //{
        //    Console.WriteLine(p.Adi);
        //}

        //public static void Test(Hoca p)
        //{
        //    Console.WriteLine(p.Adi);
        //}

        //public static void Test(Mudur m)
        //{
        //    Console.WriteLine(m.Adi);
        //}
    }
}