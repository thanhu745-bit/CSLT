using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_04
{
    internal class Ex_Nop
    {
        static void GiaiPT(int a, int b, int c)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    else
                        Console.WriteLine("Vo ly");
                }
                else
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co nghiem x = 0");
                    else
                        Console.WriteLine($"Phuong trinh co nghiem x = {(double)-c / b}");
                }
            }
            else
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Phuong trinh co nghiem x = 0");
                    else
                    {
                        if (-c / a < 0)
                            Console.WriteLine("Phuong trinh vo nghiem");
                        else
                            Console.WriteLine($"Phuong trinh co nghiem x = {Math.Sqrt(-c / a)} va x = {-Math.Sqrt(-c / a)}");
                    }

                }
                else
                {
                    if (c == 0)
                        Console.WriteLine($"Phuong trinh co nghiem x1 = 0 va x2 = {(double)-b / a}");
                    else
                    {
                        double delta = b * b - 4 * a * c;
                        if (delta < 0)
                            Console.WriteLine("Phuong trinh vo nghiem");
                        else if (delta == 0)
                            Console.WriteLine($"Phuowng trinh co nghiem kep x = {(double)-b / 2 * a}");
                        else
                            Console.WriteLine($"Phuong trinh co nghiem x1 = {(-b + Math.Sqrt(delta)) / (2 * a)} va x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");

                    }
                }

            }

        }
        static void CheckOdd_Even(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine($"{num} la so chan");
            else
                Console.WriteLine($"{num} la so le");
        }
        static void Findthelargest(int input1, int input2, int input3)
        {
            int ans = int.MinValue;
            if (ans <= input1)
                ans = input1;
            if (ans <= input2)
                ans = input2;
            if (ans <= input3)
                ans = input3;
            Console.WriteLine($"Trong ba so {input1}, {input2}, {input3} so lon nhat : {ans}");

        }
        static void check_triangle()
        {
            byte bao = 0;
            int canh1, canh2, canh3;
            Console.WriteLine("Nhap do dai lan luot ba canh:");
            do
            {
                canh1 = int.Parse(Console.ReadLine());
                canh2 = int.Parse(Console.ReadLine());
                canh3 = int.Parse(Console.ReadLine());
                if (canh1 > 0 && canh2 > 0 && canh3 > 0)
                {
                    if (canh1 + canh2 > canh3 && canh1 + canh3 > canh2 && canh2 + canh3 > canh1)
                        bao = 1;
                    else
                        Console.WriteLine("Ba canh tren khong tao thanh tam giac, vui long nhap lai!");
                }
                else Console.WriteLine("Ba canh tren khong tao thanh tam giac,, vui long nhap lai!");

            } while (bao == 0);
            if (canh1 == canh2 && canh2 == canh3)
                Console.WriteLine("Day la tam giac deu");
            else if (canh1 == canh2 || canh2 == canh3 || canh1 == canh3)
                Console.WriteLine("Day la tam gian can");
            else Console.WriteLine("Day la tam giac thuong");

            
        }
        static void Quadrant(int x, int y)
        {
            if (x > 0 && y > 0)
                Console.WriteLine($"({x},{y}) thuoc goc phan tu thu 1");
            else if (x < 0 && y > 0)
                Console.WriteLine($"({x},{y}) thuoc goc phan tu thu 2");
            else if (x < 0 && y < 0)
                Console.WriteLine($"({x},{y}) thuoc goc phan tu thu 3");
            else if (x > 0 && y < 0)
                Console.WriteLine($"({x},{y}) thuoc goc phan tu thu 4");
            else
                Console.WriteLine($"({x},{y}) khong thuoc goc phan tu nao ca");

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac he so cua phuong trinh bac 2: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GiaiPT(a, b, c);
            Console.WriteLine("\n");
            Console.WriteLine("Nhap so de check: ");
            int num = int.Parse(Console.ReadLine());
            CheckOdd_Even(num);
            Console.WriteLine("\n");
            int input1, input2, input3;
            Console.WriteLine("Nhap ba so:");
            input1 = int.Parse(Console.ReadLine());
            input2 = int.Parse(Console.ReadLine());
            input3 = int.Parse(Console.ReadLine());
            Findthelargest(input1, input2, input3);
            Console.WriteLine("\n");
            check_triangle();
            Console.WriteLine("\n");
            Console.WriteLine("Nhap toa do X, Y:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Quadrant(x, y);       

            Console.ReadKey();
        }
    }
}
