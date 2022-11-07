namespace Class_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class (Sınıf) => uygulama içerisinde kendimize ait tipler oluşturabildiğimiz yapıdır..
            // Class uygulamalardaki modüllerimizi barındandıran yapılardır...

            // Class kodları kategorize eden yapıladır. Örneği ekran işlemleri Console sınıfında, dizi işlemleri Array sınıfında, dönüşüm işlemleri Convert sınıfında geliştirilmiştir..

            //string[] kisi1 = { "Ekrem", "Yıldırım", "34", "E", "İstanbul" };
            //string[] kisi2 = { "Berat", "Akyol", "23", "E", "KahramanMaraş" };

            //string[][] kisiler = new string[2][];
            //kisiler[0] = kisi1;
            //kisiler[1] = kisi2;

            // oop yaklaşımı

            // classların özelliklerine nesneler üzerinden erişebiliriz.

            // k değişkeni nesneyi ifade eder. Kullanıcı tipinde k nesnesi..

            Kullanici k = new Kullanici();
            k.adi = "Berat";
            k.yas = 23;
            k.cinsiye = 'e';

            Kullanici k1 = new Kullanici();
            k1.adi = "Umut";
            k1.yas = 30;
            k1.cinsiye = 'e';


            Console.WriteLine("Hello, World!");
        }
    }
}