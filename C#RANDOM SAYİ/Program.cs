 ﻿using System;

class Program
{
    static void Main()
    {
        int isayi, bsayi, endsayi;

        Console.WriteLine("Kaç tane random sayı istiyorsun");
        isayi = int.Parse(Console.ReadLine());
        if (isayi >0)
        {
       

        Console.WriteLine("başlangıç sayını gir");
        bsayi = int.Parse(Console.ReadLine());
        Console.WriteLine("bitiş sayını gir");
        endsayi = int.Parse(Console.ReadLine());

            if(endsayi-bsayi>isayi)
            {
            
             Random rnd = new Random();
              int[] sayilar = new int[isayi];

        for (int i = 0; i < isayi;)
        {
            int eray = rnd.Next(bsayi, endsayi + 1);
            bool benzersiz = true;

            for (int j = 0; j < i; j++)
            {
                if (sayilar[j] == eray)
                {
                    benzersiz = false;// benzersiz kontrolu 
                    break;
                }
            }

            if (benzersiz)
            {
                sayilar[i] = eray;
                i++;
            }
        }

        Array.Sort(sayilar);

        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

            }
            else
            {
                Console.WriteLine($"Random Sayi miktarını En fazla {endsayi-bsayi} giriniz. Yada bitiş sayınızı büyütünüz");
            }

       
        }
        else { Console.WriteLine("Hatalı giriş yaptınız.0 dan büyük değer giriniz."); }
        Console.ReadKey();
    }
}
