
using System;

Console.Write("bir sayı girin: ");
int sayi =
    Convert.ToInt32(Console.ReadLine());

int toplam = 0;
for (int i = 1; i < sayi; i++)
{
    if (sayi % i == 0)
    {
        toplam += i;


    }
}

if (toplam == sayi)
{

    Console.WriteLine("mükemmel bir sayıdır");

}

else
{

    Console.WriteLine("mükemmel bir sayı değildir");


}
