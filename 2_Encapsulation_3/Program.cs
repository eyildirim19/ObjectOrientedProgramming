namespace _2_Encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kullanici k = new Kullanici();
            //k.Email = "ldskaldş";// set bloğu olmadığı için bu property read only property'dir....
            k.Adi = "berat";
            k.SoyAdi = "Akyol";


            Kullanici k1 = new Kullanici();
            k1.Adi = "Umut";
            k1.SoyAdi = "Yasan";


             Console.WriteLine($"{k.Adi} {k.SoyAdi} {k.Email}");

            Console.WriteLine($"{k1.Adi} {k1.SoyAdi} {k1.Email}");

        }
    }
}