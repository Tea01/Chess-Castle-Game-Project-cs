using System;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();                 //Random classtan rnd nesnesi oluşturuldu

            int[] kutux = new int[8];                 //oluşturulacak değerleri koymak için int dizi oluşturuyoruz

            //1 den 8 e kadar random sayırlar oluşturur
            //kaleleri satırların içerisinde farklı/random yerlerde koymak için          
            for (int konum = 0; konum < 8; konum++)
            {
                kutux[konum] = rnd.Next(0, 8);       //rnd.Next(0,8)--> 0-7 e kadar random değer alıp kutux[] alanabilecek değeri 

                //kaleler aynı sütünde rastlanmamak için
                for (int location = 0; location < konum; location++)
                {
                    if (kutux[location] == kutux[konum])
                    {
                        konum--;
                        break;
                    }
                }
            }

            //1 den 8 e kadar her yeni tablo oluşturulacak için yeni ++ bir Kale yazdıracak
            for (var tablo = 0; tablo < 8; tablo++)
            {
                Console.WriteLine("KALE NO: " + (tablo + 1));

                //Kaleleri her satırda yazdırmak için
                //Sütün yazdırmak için
                for (int sutunY = 0; sutunY < tablo + 1; sutunY++)
                {
                    //satır yazdırmak için
                    for (int satirX = 0; satirX < 8; satirX++)
                    {
                        if (kutux[sutunY] == satirX)
                        {
                            Console.Write("K ");
                        }
                        else
                            Console.Write("0 ");
                    }
                    Console.WriteLine();
                }
                //her oluşturulacak tabloda 8 tane satır yazdırmak için
                for (int i = 0; i < 7 - tablo; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write("0 ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

