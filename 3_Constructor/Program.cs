using _3_Constructor; // Ogrenci sınıfının namespace'ini dosyamıza ekledik. Bu dosyanın bir namespace yoktur. kullanmak istediğimiz sınıfın vardır. bu yüzden namespaceler farklı olduğu namespace tanımlaması using ifadesi ile yapılır...


/*
 * 
Value Type  => değer tutan tipler. Struct'lar value type'tır. (int,short,byte,bool,char,double,decimal,float,ushort,ulong,uint,sbyte)

Reference Type => referans tutan tipler..
Classlar ve diziler referns tiptir..
 */

#region value Type

int a = 4;
int b = a; // b a'nın değerini tutar. çünkü b ve a bir value type'tır..
b = 1;
#endregion

Console.WriteLine(a); // 4 
Console.WriteLine(b); // 1

Ogrenci ogr = new Ogrenci();
ogr.Adi = "Berat";
ogr.SoyAdi = "Akyol";

// ogr nesnesinin instance (örneği veya referansını) ogr1 nesnesine atandı...
// ogr ve ogr1'İn bellekteki referansları aynıdır. çünkü ogr1 için bir referans oluşturulmad.
Ogrenci ogr1 = ogr;
ogr1.Adi = "Umut";

Ogrenci ogr3 = new Ogrenci();
ogr3.Adi = "Merve";

Ogrenci ogr2 = new Ogrenci("İsmail", "Kurtoğlu");

Console.WriteLine($"{ogr.Adi}");  // UMUT
Console.WriteLine($"{ogr1.Adi}"); // UMUT
Console.WriteLine($"{ogr3.Adi}"); // MERVE
Console.WriteLine($"{ogr2.Adi}"); // İsmail


Console.WriteLine("Bitti");