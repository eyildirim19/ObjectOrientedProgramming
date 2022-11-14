namespace _4_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //ExcelDosya d = new ExcelDosya();
            //d.Adi = "Hesaplar";
            //d.Uzanti = "xls";

            //d.Yazdir();

            //WordDosya d1 = new WordDosya();
            //d1.Adi = "Analiz_1";
            //d1.Uzanti = "doc";

            //d1.Yazdir();


            // Name ve Extension(Uzantı) bilgileir constructor'dan verilecektir... 
            ExcelFile ef = new ExcelFile("Hesaplar","xlsx");
            WordFile wf = new WordFile("Analiz", "docx");


            ef.Yazdir();
            wf.Yazdir();
        }
    }
}