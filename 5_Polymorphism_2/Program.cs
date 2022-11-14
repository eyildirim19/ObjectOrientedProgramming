namespace _5_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            Hoca h = new Hoca();

            DusunceGoster(o); // Hoca anlatamıyor...
            DusunceGoster(h); // Öğrenciler anlamıyor..
        }

        static void DusunceGoster(Insan i)
        {
            i.Dusunce();
        }
    }
}