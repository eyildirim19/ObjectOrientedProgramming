namespace _6_AbsractMember2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polimoprhism yaklaşımı abstract ile");

            Elektironik e = new Elektironik();
            e.Tip = "Televizyon";
            e.BirimFiyat = 1500;

            Gida g = new Gida();
            g.Tip = "Yiyecek";
            g.BirimFiyat = 150;

            BilgileriGoster(e);
            BilgileriGoster(g);
        }

        public static void BilgileriGoster(Urun urun)
        {
            Console.WriteLine($"Ürün Grup = {urun.Tip}\nBirim Fiyat {urun.BirimFiyat}\nFiyat {urun.Fiyat}\nKdvOrani {urun.Kdv}");
        }
    }
}