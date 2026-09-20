using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSLT.Session_05
{
    internal class Ex02_Nopchothay
    {
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static bool KiemTraChanLe(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        static long TinhGiaiThua(int n)
        {
            long tich = 1;
            for (int i = 1; i <= n; i++)
                tich *= i;
            return tich;
        }
        static string DaoNguocChuoi(string input)
        {
            char[] s = input.ToCharArray();
            Array.Reverse(s);
            return new string(s);

        }
        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            if (n == 2)
                return true;
            for (int i = 2; i <= (int)Math.Sqrt((double)n); i++)
                if (n % i == 0)
                    return false;
            return true;

        }
        static void InFibonacci(int n)
        {
            int[] A = new int[10000];
            A[1] = 0;
            A[2] = 1;
            for (int i = 3; i <= n; i++)
                A[i] = A[i - 1] + A[i - 2];
            for (int i = 1; i <= n; i++)
                Console.Write($"{A[i]} ");
            Console.WriteLine("\n");


        }
        static int DemNguyenAm(string s)
        {
            int dem = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    dem += 1;
            return dem;
        }
        static double TinhTrungbinh(int[] pars)
        {
            double sum = 0, dem = 0;
            for (int i = 0; i < pars.Length; i++)
            {
                sum += pars[i];
                dem += 1;
            }
            double tbinh = sum / dem;
            return tbinh;
        }
        static double TinhLuyThua(double x, int y)
        {
            long tich = 1;
            for (int i = 1; i <= y; i++)
                tich *= (long)x;
            return tich;
        }
        public static void Main(string[] args)
        {
            ////Bai 1: Tinh tong hai so nguyen
            //Console.WriteLine("Nhap vao hai so a va b");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a} + {b} = {TinhTong(a, b)}");
            //Console.WriteLine("\n");
            ////Bai 2: Kiem tra so chan le
            //Console.WriteLine("Nhap vao so de check");
            //int n = int.Parse(Console.ReadLine());
            //if (KiemTraChanLe(n))
            //    Console.WriteLine($"{n} la so chan");
            //else
            //    Console.WriteLine($"{n} la so le");
            //Console.WriteLine("\n");
            ////Bai 3: Tim so lon nhat trong ba so
            //Console.WriteLine("Nhap vao ba so x y z");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());
            //Console.WriteLine($"So lon nhat trong ba so: {TimMax(x, y, z)}");
            //Console.WriteLine("\n");
            ////Bai 4: Tinh giai thua cua mot so
            //Console.WriteLine("Nhap vao m");
            //int m = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{m}! = {TinhGiaiThua(m)}");
            //Console.WriteLine("\n");
            ////Bai 5: Dao nguoc chuoi ky tu
            //Console.WriteLine("Nhap vao chuoi ky tu");
            //string s = Console.ReadLine();
            //Console.WriteLine($"Chuoi dao nguoc: {DaoNguocChuoi(s)}");
            //Console.WriteLine("\n");
            ////Bai 6: Kiem tra so nguyen to
            //Console.WriteLine("Nhap vao mot so de ktra snto");
            //int k = int.Parse(Console.ReadLine());
            //if (KiemTraNguyenTo(k))
            //    Console.WriteLine("True");
            //else
            //    Console.WriteLine("False");
            ////Bai 7: In day Fibonacci
            //Console.WriteLine("Nhap vao T - T so dau tien cua day Fibonacci");
            //int T = int.Parse(Console.ReadLine());
            //InFibonacci(T);
            //Console.WriteLine("\n");
            ////Bai 8: Dem so luong nguyen am trong chuoi
            //Console.WriteLine("Nhap vao chuoi ky tu");
            //string s1 = Console.ReadLine();
            //Console.WriteLine($"So luong ky tu nguyen am : {DemNguyenAm(s1)}");
            //Console.WriteLine("\n");
            ////Bai 9: Tinh luy thua
            //Console.WriteLine("Nhap vao hai so x1 y1");
            //double x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"x^y = {TinhLuyThua(x1, y1)}");
            //Bai 10: Tinh diem trung binh cua mang
            Console.WriteLine("Nhap vao 1 mang:");
            string s2 = Console.ReadLine();
            string[] s3 = s2.Split(',');
            int[] arr = new int[s3.Length];
            for (int i = 0; i < s3.Length; i++)
                arr[i] = int.Parse(s3[i]);
            Console.WriteLine($"Gia tri trung binh cua mang: {TinhTrungbinh(arr)}");







        }

    }
}
