namespace _2_Encapsulation_2
{

    // Class members => sınıfın üyelerini ifade eder;
    // field, metot,
    // property  => sınıfların içerisinde metot veya field gibi kullanılabilen yapılardır... 

    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.AdSoyAd = "Umut";
            ogr.Yas = 13; // propert'nin set bloğu çalışır
            //ogr.KursAdi = "kdaklsdal"; // bu property read only (sadece okunabilir) bir propert'dir. çünkü property'nin set bloğu yoktur..

            Ogrenci ogr1 = new Ogrenci();
            ogr1.AdSoyAd = "Berat";
            ogr1.Yas = 17;

            Ogrenci ogr2 = new Ogrenci();
            ogr2.AdSoyAd = "İsmail";
            ogr2.Yas = 22;


            // property'nin get bloğu çalışır
            Console.WriteLine($"{ogr.Yas} {ogr1.Yas} {ogr2.Yas}");

        }
    }
}