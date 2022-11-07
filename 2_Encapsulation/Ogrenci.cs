using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Encapsulation
{
    // Encapsulation => (Kapsülleme veya koruma altına alma) => Encapsulation bir oop yaklaşımıdır...sınıfın üyelerinin koruma altına alınmasıdır. üyeler değiştirlmesini engellemek veya üyenin kontrollü bir şekilde okunmasını, yazılmasını sağlamaktatır. üyelerin kontrollü bir şekilde dışarı açılmasıdır..

    // Encapsulation için erişim seviyelerini bilmekte fayda var;
    /*
            Sınıflarımızın veya üyelerimizin erişim belirteçleridir...

            public   => genel proje içerisinden veya dışarısından erişilebilecek yapıları belitmek için kullanılır..

            internal => proje içerisinde (derlenen proje içerisinde). sınıfların default erişim seviyesidir..

            procted  => sınıf içerisinden veya sınıftan türeyen sınıflardan erişmek için kullanılır

            private  => sadece sınıf içerisinden erişebilen yapılardır..

    procted ve private sadece üyelere kullanılabilir. yani sınıflar private veya procted olamaz..
    public ve internal sınıflar ve üyeleri için kullanılabilir... eğer sınıf erişim belirteci internal üyeler public ise sınıf eriişm belirteci geçerlidir..
        
            protected internal => protected ve internal'in karışımıdır...

     */

    internal class Ogrenci
    {
        public string adsoyad;

        private int yas;

        // sınıf özel (private) üyelerine atama yaparken setter metotlar, okuma yaparken getter metotlar kullanılır
        public void SetYas(int y)
        {
            #region "if"
            //if (y < 18)
            //{
            //    yas = 18;
            //}
            //else
            //{
            //    yas = y;
            //}
            #endregion
            // ternary if...
            yas = y < 18 ? 18 : y;
        }

        public int GetYas()
        {
            return yas;
        }

        // Not : kapsülleme konusunu bundan sonra propertyler ile devam ettireceğiz..

    }
}
