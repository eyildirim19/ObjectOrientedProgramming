using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Interface_1
{
    // interface (arayüzler) => birden fazla yapıdan miras almamızı sağyalan yapılardır.. (multiple inheritance)

    // interfaceler soyut varlıklardır. sadece miras vermek için tanımlanır...

    // abstract classlara benzler ancak abstract yapılarda tek kalıtım, interfacelerde çoklu kalıtım yapılır...

    // interfacelerde field tanımlanamaz...
    // interface üyelerinin gövdeleri yazılamayabilir.. ( // 8.0 ile gövdeli üyeler tanımlanabilir

    public interface ITest
    {
        //string adi;

        void Demo();

        // 8.0 ile interface üyelerinin access modifersi belirtilebliyor...
        public void De()
        {

        }
    }
}
