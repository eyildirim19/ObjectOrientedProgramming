namespace _2_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas = 15, yas2 = 17, yas3 = 22;
            Ogrenci ogr = new Ogrenci();
            ogr.adsoyad = "Umut";

            ogr.SetYas(yas);
           // ogr.yas = 10; // yas üyesi private olduğu için buradan değer atanamaz...
        
            Ogrenci ogr1 = new Ogrenci();
            ogr1.adsoyad = "Berat";
            ogr1.SetYas(yas2);
            // ternary if (tek satırda if). kosul ? kosulsağlanıyorsa : koşulsağlanmıyorsa...
            // değer ataması yaparken kullanılan if türüdür..
            // ogr1.yas = yas2 < 18 ? 18 : yas2;

            Ogrenci ogr3 = new Ogrenci();
            ogr3.adsoyad = "İsmail";
            ogr3.SetYas(yas3);
            // ogr3.yas = yas3 < 18 ? 18 : yas3;


            Console.WriteLine($"{ogr.GetYas()} {ogr1.GetYas()} {ogr3.GetYas()}");



            Console.WriteLine("Hello, World!");
        }
    }
}