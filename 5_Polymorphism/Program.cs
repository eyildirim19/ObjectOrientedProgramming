namespace _5_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi k = new Kedi();
            Console.WriteLine(k.Ses());

            Kus ku = new Kus();
            Console.WriteLine(ku.Ses());

            Kopek k1 = new Kopek();

            // miras veren sınıf ile miras alan sınıf yer değiştiklerinden birbirileri gibi davranabilmelidir...
            // k nesnesi h nesnesine atandığında h k gibi davranabilmelidir....
            //HayvanlarAlemi h = k; // kedi
            //Console.WriteLine(h.Ses());

            //HayvanlarAlemi h1 = ku;
            //Console.WriteLine(h1.Ses());
            Yazdir(ku);
            Yazdir(k);
            Yazdir(k1);
        }

        static void Yazdir(HayvanlarAlemi h)
        {
            Console.WriteLine(h.Ses());
        }
    }
}