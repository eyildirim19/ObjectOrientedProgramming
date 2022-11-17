namespace _7_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MesajXml x = new MesajXml();
            VeriGoster(x);

            MesajJson j = new MesajJson();
            VeriGoster(j);
        }
        static public void VeriGoster(IMessage m)
        {
            m.Message();
        }
        //static public void VeriGoster(MesajXml msg)
        //{
        //    msg.Message();
        //}

        //static public void VeriGoster(MesajJson j)
        //{
        //    j.Message();
        //}
    }
}