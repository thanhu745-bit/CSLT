using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CSLT.Session_04
{
    internal class Buoi2
    {
        static void Bangcuuchuong()
        {
            int n = 15;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} x {j} = {i * j}\t");
                }
                Console.WriteLine("\n");
            }

        }
        static void BT1()
        {
            int canh1, canh2, canh3;
            do
            {
                Console.WriteLine("Nhap do dai ba canh");
                canh1 = int.Parse(Console.ReadLine());
                canh2 = int.Parse(Console.ReadLine());
                canh3 = int.Parse(Console.ReadLine());
                if (canh1 > 0 && canh2 > 0 && canh3 > 0)
                {
                    if (canh1 + canh2 > canh3 && canh1 + canh3 > canh2 && canh2 + canh3 > canh1)
                    {
                        if (canh1 == canh2 && canh2 == canh3)
                        {
                            Console.WriteLine($"Do dai ba canh {canh1}, {canh2}, {canh3} tao thanh tam giac deu");
                            break;
                        }
                        else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
                        {
                            Console.WriteLine($"Do dai ba canh {canh1}, {canh2}, {canh3} tao thanh tam giac can");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Do dai ba canh {canh1}, {canh2}, {canh3} tao thanh tam giac thuong");
                            break;
                        }

                    }
                    else
                        Console.WriteLine("Khong thoa man dieu kien mot tam giac, vui long nhap lai");

                }
                else
                    Console.WriteLine("Khong thoa man dieu kien mot tam giac, vui long nhap lai");
            } while (true);
        }

        static void BT2()
        {
            int num, sum = 0;
            double average;
            Console.WriteLine("Nhap 10 so");
            for (int i = 1; i <= 10; ++i)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            average = (double)sum / 10D;
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");

        }
        static void BT3()
        {
            int input;
            Console.WriteLine("Nhap so dau vao");
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{input} x {i} = {input * i}");

        }
        static void BT4()
        {
            Console.WriteLine("Hinh thu nhat");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write($"{j}");
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Hinh thu hai");
            int so = 1;
            for (int i = 1; i <= 4; i++)
            {                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{so} ");
                    ++so;
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Hinh thu ba");
            so = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4 - i; j++)
                    Console.Write(" ");
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{so} ");
                    ++so;
                }
                
                Console.WriteLine();
            }

        }
        static void BT6()
        {
            int n;
            double theirsum = 0;
            Console.WriteLine("Nhap n");
            do
            {
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Sai dieu kien voi n, vui long nhap lai");
                }
                else if (n > 0)
                    break;

            } while (true);
            for (int i = 1; i <= n; i++)
                theirsum += (1.0 / i);
            Console.WriteLine($"Sum of Harmonic series: {theirsum:f3}");
            

        }
        
        static void BT7()
        {
            int left, right,sum;
            byte bao = 0;
            Console.WriteLine("Nhap gioi han hai dau cua day so");
            left = int.Parse(Console.ReadLine());
            right = int.Parse(Console.ReadLine());
            Console.WriteLine($"Day so 'Perfect' tu {left} den {right}: ");
            for (int i = left; i <= right; i++)
            {
                sum = 0;
                double tam = (double)i;
                for (int j = 1; j <= Math.Sqrt(tam); j++)
                {
                    if (i % j == 0)
                    {
                        if (i != j) sum += j;
                        if (j != i / j && j != 1)
                            sum += i / j;
                    }
                }
                if (sum == i)
                {
                    Console.Write($"{i} ");
                    bao = 1;
                }


            }
            if (bao == 0)
                Console.WriteLine("Khong có");
            
        }

        public static void Main(string[] args)
        {
            Bangcuuchuong();
            BT1();
            BT2();
            BT3();
            BT4();
            BT6();
            BT7();
            Console.ReadKey();
        }
    }
}
