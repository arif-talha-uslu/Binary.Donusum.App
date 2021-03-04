using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary.Donusum.App
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.WriteLine("Kaça bölücez?:");
                byte basamak = byte.Parse(Console.ReadLine());
                switch (basamak)
                {
                    case 2:
                        for (; ; )
                        {
                            Console.WriteLine("SAYIYI GİR");
                            int onluk = int.Parse(Console.ReadLine());

                            int sonuc = onluk / 2;
                            int kalan = onluk % 2;
                            Console.WriteLine($"sonuç:{sonuc} kalan:{kalan}");
                        }
                        break;
                    case 8:
                        for (; ; )
                        {
                            Console.WriteLine("SAYIYI GİR");
                            int onluk = int.Parse(Console.ReadLine());

                            int sonuc = onluk / 8;
                            int kalan = onluk % 8;
                            Console.WriteLine($"sonuç:{sonuc} kalan:{kalan}");
                        }
                        break;
                    case 16:
                        Console.WriteLine("1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,10,11,12,13,14");
                        for (; ; )
                        {
                            Console.WriteLine("SAYIYI GİR");
                            int onluk = int.Parse(Console.ReadLine());

                            int sonuc = onluk / 16;
                            int kalan = onluk % 16;
                            Console.WriteLine($"sonuç:{sonuc} kalan:{kalan}");
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
