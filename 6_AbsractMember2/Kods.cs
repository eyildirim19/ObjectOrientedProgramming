using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AbsractMember2
{
    public abstract class Urun
    {
        public string Tip { get; set; }
        public decimal BirimFiyat { get; set; }
        public abstract decimal Kdv { get; }
        public decimal Fiyat
        {
            get
            {
                return BirimFiyat * Kdv;
            }
        }
    }
    public class Elektironik : Urun
    {
        public override decimal Kdv
        {
            get { return 1.18m; }
        }
    }

    public class Gida : Urun
    {
        public override decimal Kdv
        {
            get { return 1.01m; }
        }
    }
}
