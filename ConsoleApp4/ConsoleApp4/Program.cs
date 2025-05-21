// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int vize, final, ort, bütünleme;
Console.Write("Vize Notunu Giriniz:");
vize = Convert.ToInt32(Console.ReadLine());
Console.Write("Final Notunu Giriniz:");
final= Convert.ToInt32(Console.ReadLine());
ort=(vize+final)/2;
if (ort < 45)
{
    Console.WriteLine("Dersten Kaldınız Bütünlemeye Giriniz:");
    Console.Write("Bütünleme Notunuzu Giriniz:");
    bütünleme = Convert.ToInt32(Console.ReadLine());
    if (bütünleme >= 50)
    {
        Console.WriteLine("Geçtiniz.");
    }
    else
    {
        Console.WriteLine("Kaldınız.");
    }
    Console.ReadKey();
}


