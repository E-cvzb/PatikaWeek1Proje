using System.Text.Json.Serialization;

Console.WriteLine("Merhabalar lütfen gelen soruları cevaplayınız.");

Console.Write("TC kimlik numaranız?");
string tc = Console.ReadLine();

Console.Write("Adınız?");
string name = Console.ReadLine();

Console.Write("Soyadınız?");
string lastname= Console.ReadLine();

Console.Write("Tefefon numaranızı giriniz?"); // telefon numarasını string olarak tanımladım çünkü herhangi bir işlem yapılmayacağı için bir dönüşün yapmaya gerk duymadım 
string number = Console.ReadLine();

Console.Write("Yaşınız?");
string age = Console.ReadLine();

Console.Write("İlk almış olduğunuz ürünün fiyatı?");// ürün fiyatını tanımlarken double formunda ayzmayı uygun gördüm çünkü string formunda yazarken karakter olarak algılayacağı için toplam işlemini yapamayacaktır
double sel1 = Convert.ToDouble(Console.ReadLine());

Console.Write("İkinci almış olduğunuz ürünün fiyatı?");
double sell2 = Convert.ToDouble(Console.ReadLine());

double toplam = sel1  + sell2;

Double indirim = toplam / 5;

Console.WriteLine($"{tc} Tc numaralı {name} {lastname} hesabınızın kurulumu tanımlanmıştır.");
Console.WriteLine($"{number} numaralı telefonunuza aktivasyon kodu gönderilmiştir");
Console.WriteLine($"{toplam} tutarındaki alışverişiniz tanımlanmıştır.Bu alışverişten % 20 indirim kazandınız {indirim} tutarındaki indirim kupon hesabınıza tanımlanmıştır.");