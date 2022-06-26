using System;

namespace TekrarKodlari
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;// int tipindeki sayi1 adlı değişkenin değeri 10'dur
            int sayi2 = 20;// int tipindeki sayi2 adlı değişkenin değeri 20'dir//102
            
            sayi1 = sayi2;// sayi1 'in değeri sayi2'nin değeridir
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[3] { 1, 2, 3 }; //101
            int[] sayilar2 = { 100, 200, 300 };//102
           //************ Heap **********************
          
            //102 = {100,200,300}
            sayilar1 = sayilar2;//sayilar1 =101 sayilar2 = 102
            //102
            sayilar2[0] = 25;

            Console.WriteLine(sayilar1[0]);
            //{25,200,300 }
            Aciklama deneme;
            deneme = new Aciklama();


            deneme.Ekle();
           
            
        }
    }
}
