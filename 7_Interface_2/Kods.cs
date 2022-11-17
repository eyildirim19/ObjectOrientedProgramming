using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_2
{
    // geliştirme (01.01.2022)
    public class MesajXml : IMessage
    {
        public void Message()
        {
            Console.WriteLine("<msg>merhaba</msg>");
        }
    }

    // geliştirme (17.11.2022)
    public class MesajJson : IMessage
    {
        public void Message()
        {
            Console.WriteLine("{'msg':'merhababa'}");
        }
    }
}