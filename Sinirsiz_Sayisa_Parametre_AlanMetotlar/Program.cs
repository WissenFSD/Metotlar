// See https://aka.ms/new-console-template for more information


IlkMetot(1, 3, 3,4,3,1,2,5,6,36,12,78,15,88);


// Bir metodu sınırsız adet parametreli hale çevirmek için params keyword'unu kullanıyoruz.
// Params keyword'ü ile oluşturulan metotlar sınırsız adet parametre alabilmektedirler
static void IlkMetot(params int[] parametre)
{

    Console.WriteLine(parametre.Length);

}

