// See https://aka.ms/new-console-template for more information


// Metot yazmak kod tekrarını engeller
// İş yapan ufak kod parçacıklarına metot denir
// Metotlar aldıkları belirli değerler ile ilgili işler yapıp size sonuçlar verebilmektedir.
Test();
Test();



Random rnd = new Random();
int sayi = rnd.Next();


// her metodun bir imzası olması gerekmektedir.
// erişim belirleyici
// static yada static olmalışı
// geri dönüş tipi
// Adı
// Aldığı parametreler
// Gövde


// Geri dönüş tipi olmayan ve parametre almayan metot
// Geri görüş tipi olan ve parametre almayan metot
static void Test()
{
    Console.WriteLine("Test");
}

// Parametre almayan ve geriye değer döndüren metot
static int Test2()
{
    return 10;

}

// int tipinde değer alan ve geriye değer döndürmeyen metot
static void Test3(int a)
{


}

// Parametre alan ve geriye değer döndüren metot
static string Test4(string deger)
{

    return "random değer";
}