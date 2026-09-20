using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.Session_05
{
    internal class Ex01
    {
        static int find_maximum(int a, int b, int c )
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }
        static bool check_n(int k)
        {
            
            if (k < 0)
                return false;
            if (k > 0)
                return true;
            return false;
        }
        static long Giaithua(int k)
        {
            long tich = 1;
            for (int i = 1; i <= k; i++)
                tich *= i;
            return tich;

        }
        static bool Ktra_Prime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            for (int i = 2; i <= (int)(Math.Sqrt((double)number)); i++)
                if (number % i == 0) return false;
            return true;
        }
               
        static byte Check_sonto(double n)
        {
            if (n < 2) return 0;
            if (n == 2) return 1;
            for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                if (n % i == 0)
                    return 0;
            return 1;
        }

        static byte Check_perfectnum(double n)
        {
            int sum = 0;
            for (int i = 1; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0 && i != n)
                {
                    sum += i;
                    if (n / i != i && n / i != n)
                        sum += (int) n / i;
                }
            }
            if (sum == n)
                return 1;
            else
                return 0;
        }
         
        static byte Check_pangram(string p)
        {
            byte[] danhdau = new byte[150];
            for (int i = 97; i <= 122; i++)
                danhdau[i] = 0;
            p = p.ToLower();
            p = p.Trim();
            for (int i = 0; i < p.Length; i++)
                if (97 <= (char)p[i] && (char)p[i] <= 122)
                    ++danhdau[(char)p[i]];
            for (int i = 97; i <= 122; i++)
                if (danhdau[i] == 0) return 0;
            return 1;

        }
        public static void Main(string[] args)
        {
            //Bai 1: Write a C# function to find the maximum of three numbers
            Console.WriteLine("Nhap vao lan luot ba so :");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"So lon nhat trong ba so la : {find_maximum(input1, input2, input3)}");
            Console.WriteLine("\n");

            //Bai 2: Write a C# function to calculate the factorial of a number (a non-negative integer)
            int n;
            Console.WriteLine("Nhap vao n de tinh giai thua :");
            do
            {
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (check_n(n) == false)
                        Console.WriteLine("Dieu kien n khong am, vui long nhap lai!");
                    else
                        break;

                }
                else
                    Console.WriteLine("Dieu kien n khong am, vui long nhap lai!");
            } while (true);
            Console.WriteLine($"{n}! = {Giaithua(n)}");
            Console.WriteLine("\n");

            //Bai3: Write a C# function that takes a number as a parameter and checks whether
            //the number is prime or not.
            Console.WriteLine("Nhap vao n de kiem tra snt :");
            int num_prime = int.Parse(Console.ReadLine());
            if (Ktra_Prime(num_prime))
                Console.WriteLine($"{num_prime} la so nguyen to");
            else
                Console.WriteLine($"{num_prime} khong la so nguyen to");
            Console.WriteLine("\n");

       // Bai4: Write a C# function to print
            //1.all prime numbers that less than a number(enter prompt keyboard).
            //2.the first N prime numbers
            Console.WriteLine("Nhap vao T (nguong yeu cau):");
            int T = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cac so nuyen to nho hon {T}: ");
            for (int i = 1; i <= T; i++)
                if (Check_sonto((double)i) == 1)
                    Console.Write($"{i} ");
            Console.WriteLine("\n");
            Console.WriteLine("Nhap vao N - la so luong snt dau tien:");
            int N = int.Parse(Console.ReadLine());
            int dem = 0, k = 1;
            Console.WriteLine($"{N} so nguyen to dau tien la");
            while (dem < N)
            {
                if (Check_sonto(k) == 1)
                {
                    Console.Write($"{k} ");
                    ++dem;
                }
                ++k;

            }
            Console.WriteLine("\n");
        //Bai6: print all perfect number that less than 1000
            Console.WriteLine("Các số hoàn hảo nhỏ hơn 1000 là:");
            for (int i = 1; i <= 1000; i++)
                if (Check_perfectnum(i) == 1)
                    Console.Write($"{i} ");
            Console.WriteLine("\n");

        //Bai5: check whether a string is a pangram or not
            string s = Console.ReadLine();
            if (Check_pangram(s) == 1)
                Console.WriteLine("Chuoi tren la Pangram");
            else
                Console.WriteLine("Chuoi tren khong la Pangram");
           

            Console.ReadKey();
        }
    }
}
