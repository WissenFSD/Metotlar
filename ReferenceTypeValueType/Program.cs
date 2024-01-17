// See https://aka.ms/new-console-template for more information


int a = 30;
string b = "Veri";
int[] dizi = new int[3] { 1, 2, 3, };


Console.WriteLine(b);
Console.WriteLine(a);
Console.WriteLine(dizi[0]);

Degistir(a);
StringDegistir(b);
DiziDegistir(dizi);

Console.WriteLine(b);
Console.WriteLine(a);
Console.WriteLine(dizi[0]);

Console.ReadLine();

static void DiziDegistir(int[] dizi)
{

    dizi[0] = 100;
}
static void Degistir(int a)
{

    a = 20;
}
static void StringDegistir(string a)
{

    a = "Değişti";
}
