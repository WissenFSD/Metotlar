// See https://aka.ms/new-console-template for more information

// Örnek 1 : Ekrandan aldığı değeri ters çevirip ekrana yazan örnek
using System.Collections.Concurrent;
using System.Globalization;

//Console.WriteLine("Lütfen bir yazı yazınız");
//string yazi = Console.ReadLine();


//string metotdanGelen = TersCevir(yazi);
//Console.WriteLine(metotdanGelen);

int sonuc =KacKelime("kaç kelime olduğunu bul");
Console.WriteLine(sonuc);


Console.WriteLine(RakamSil("5445İST888rakambesi11322ktas"));


// 

// 
// girilen bir cümlenin içeriisndeki rakamları temizleyin uygulama


//bir cümlenin içerisinde kaç adet kelime geçtiğini söyleyen bir metot yazınız


static string RakamSil(string deger) {

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
