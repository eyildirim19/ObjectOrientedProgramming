namespace _6_AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.Cinsyet = 'K';
            o.AdSoyAd = "Merve";
            o.Not = 90;

            Hoca h = new Hoca();
            h.AdSoyAd = "Ekrem";
            h.Cinsyet = 'E';
            h.Maas = 300;

            // Base sınılar derived sınıfların sadece referanslarını tutarlar...
            Insan[] sinif = new Insan[2];
            sinif[0] = o; // o nesnesi
            sinif[1] = h; // h nesnesi

            foreach (Insan insan in sinif)
            {
                Console.WriteLine(insan.AdSoyAd);
                Console.WriteLine(insan.Cinsyet);
                // is operatörü karşılaştırma operatörüdür... tip karşılaştırır...
                // == operatörü karşılaştırma operatörüdür... değer karşılaştırır 
                if (insan is Ogrenci)
                {
                    // 2. yöntem
                    //Ogrenci tmp = insan as Ogrenci;
                    // 1 . yöntem
                    Ogrenci tempo = (Ogrenci)insan;
                    Console.WriteLine(tempo.Not);
                }
                else if (insan is Hoca)
                {
                    Hoca hoa = (Hoca)insan;
                    Console.WriteLine(hoa.Maas);
                }
                // Cast operatöründe eğer dönüş yapılamıyorsa exception fırlatır...
                // as operatöründe eğer dönüş yapılamıyorsa null döner..
                //Console.WriteLine(insan.Not);
            }
            // hata çünkü Insan sınıfı abstract olduğu için instance alınabilen bir tip değildir...
            //Insan i = new Insan();
            //i.AdSoyAd = "Ebubekir";
            //i.Cinsyet = 'E';
        }

    }
}