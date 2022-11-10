namespace _3_Constructor_Encapsulate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci(50, 40, "Gökhan");
            //ogr.Vize = 50;
            //ogr.Final = 90;
            float o = ogr.Vize * 0.4f + ogr.Final * 0.6f;

            Ogrenci ogr1 = new Ogrenci(90, 60, "Umut");
            //ogr1.Vize = 90;
            //ogr1.Final = 60;

            //float o1 = ogr1.Final * 0.4f +
        //    ogr1.Final * 0.6f;

            Console.WriteLine(ogr.Ortalama);
            Console.WriteLine(ogr1.Ortalama);
            Console.WriteLine(ogr1.HarfNotu);


            // kısır döngüye girer dikkat..
            //while (true)
            //{
            //    Ogrenci ogr = new Ogrenci();
            //}


        }

    }
}