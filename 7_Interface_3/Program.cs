namespace _7_Interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Egitmen egt = new Egitmen();
            egt.Adi = "Ekrem";

            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "İsmail";

            EgitimDanismani ed = new EgitimDanismani();
            ed.Adi = "yıldız";

            // interfacelerden instance alınamaz...
            //IPersonel personel = new IPersonel();
            IPersonel personel;
            personel = egt;
            personel.MaasOde();

            personel = ed;
            personel.MaasOde();

            //personel = ogr; // ogr nesnesi IPersonel tipinde olmadığı için atama yapılamaz...
        }
    }
}