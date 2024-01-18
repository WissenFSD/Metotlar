// See https://aka.ms/new-console-template for more information

// Struct  her ikisinden de nesne oluşabilir

// Class  her ikisinden de nesne oluşabilir


#region Ref

// Bazı durumlarda değer tipli değişkenleri(Struct) referans tipli gibi davrandırmak isteyebiliriz.
// Bu gibi durumlarda karşımıza ref anahtar sözcühgü çıkmaktadır.
int a = 20;
Console.WriteLine(a);

// Ref kullanımı, a değişkenini metodun içerisine referans tipli gibi gönderdik.
// Bu durumda metodun içerisine reference type olarak giden int değişikliği metotdan çıktıktan sonra da etkili oldu
Normal(ref a);
Console.WriteLine(a);

static void Normal(ref int a)
{

    a = 30;
}


#endregion

#region Out
// Out keyword ile bir değişkene başlangıç değeri vermeden uygulamayı derleyebilirsiniz
// Bir metodu out olarak işaretlemek demek o metot içerisindeki bir değişkenin başlangıç değeri alacağını söylemiş olursunuz.
// Out kullanılacaksa outlanacak değişkenin değerinin olmaması gerekmektedir.


int degisken;

OutMetot(out degisken);
Console.WriteLine(degisken);


int sayisal;

static void OutMetot(out int a)
{
    a = 30;
}

#endregion