// See https://aka.ms/new-console-template for more information

// Örnek 1 : Ekrandan aldığı değeri ters çevirip ekrana yazan örnek
using System.Collections.Concurrent;
using System.Globalization;

//Console.WriteLine("Lütfen bir yazı yazınız");
////string yazi = Console.ReadLine();


////string metotdanGelen = TersCevir(yazi);
////Console.WriteLine(metotdanGelen);

//int sonuc = KacKelime("kaç kelime olduğunu bul");
//Console.WriteLine(sonuc);


//Console.WriteLine(RakamSil("5445İST888rakambesi11322ktas"));


// Üçgen çevre ve alan hesabı
//int alan = Alan(5, 15);
//Console.WriteLine("Alan : {0}",alan);


// Diziyi ters çevirme

//int[] dizi = new int[] {1,2,3,4,5};
//// 
//int[] tersDizi = TersDizi(dizi);
//foreach (var item in tersDizi)
//{
//    Console.WriteLine(item);
//}



// girilen bir metnin tersi ile metin birbirinin aynımı

//string deger = "kapak";
//bool esitmi = TersiEsitmi(deger);
//Console.WriteLine(esitmi);
//Console.ReadLine();

// ÖDEV

// Girilen dizi içerisinde tekrarlayan elemanları bulan bir metot yazınız


static string RakamSil(string deger)
{

    //asci rakam konumları bulunur kontrol edilir
    // tüm alfabe yazılır ve her bir harf o alfabe üzerinden kontrol edeilir.
    // char.İsDigit gibi fonksiyonlar kullanılır.

    string temiz = "";
    for (int i = 0; i < deger.Length; i++)
    {

        if (char.IsLetter(deger[i]))
        {
            temiz += deger[i];
        }
    }
    return temiz;


}
static int KacKelime(string deger)
{
    int kelime = 1;
    for (int i = 0; i < deger.Length; i++)
    {
        if (deger[i] == ' ')
        {
            kelime++;
        }
    }
    return kelime;

}
static string TersCevir(string deger)
{
    string yeniDeger = "";
    for (int i = deger.Length - 1; i >= 0; i--)
    {
        yeniDeger += deger[i];

    }
    return yeniDeger;
}
static int Cevre(int birinvi_kenar, int ikinci_kenar, int ucuncu_kenar)
{

    int toplam = birinvi_kenar + ikinci_kenar + ucuncu_kenar;
    return toplam;
}
static int Alan(int taban, int yukseklik)
{
    int sonuc = (taban * yukseklik) / 2;

    return sonuc;
}
static bool KullaniciGiris(string username, string password)
{

    string kadi = "root";
    string sifre = "1010";

    return username == kadi && password == sifre;
}
static int[] TersDizi(int[] dizi)
{
    int[] tersDizi = new int[dizi.Length];
    int a = 0;
    for (int i = dizi.Length - 1; i >= 0; i--)
    {
        tersDizi[a] = dizi[i];
        a++;
  
    }
    return tersDizi;
    // Bubble sorting
}
static bool  TersiEsitmi(string deger)
{
    string ters = "";
    for (int i = deger.Length - 1; i >= 0; i--)
    {
        ters += deger[i];
    }
    return deger == ters;

}







// 3gen'in alanını ve çevresini hesaplayan metot
// Kullanıcıdan kullanıcı adı ve şifre alıp dopru ise true yanlış ise false dönen metot örneği yapalım
// int dizi alan ve bu diziyi tersten sıralayan bir metot örnepi yazınız



