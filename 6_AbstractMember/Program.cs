namespace _6_AbstractMember
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kedi k = new Kedi();
           //Console.WriteLine(k.Ses());
            
            Kus ku = new Kus();
            //Console.WriteLine(ku.Ses());

            SesCikar(k);
            SesCikar(ku);
        }

        static void SesCikar(HayvanlarAlemi h)
        {
            Console.WriteLine(h.Ses());
        }
    }
}