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
        static bool KiemTraDoiXung(string s)
        {
            char[] a = s.ToCharArray();
            Array.Reverse(a);
            string ans = new string(a);
            if (ans == s) return true;
            else
                return false;

        }
        static double CelsiusToFahrenheit(double c)
        {
            return c * 1.8D + 32D;
        }
        static int TimMin(int[] arr)
        {
            int ans = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
                ans = Math.Min(ans, arr[i]);
            return ans;

        }
        static int TongCacChuSo(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }
        static void SapXepMang(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");

        }
        static string XoaTrungLap(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            return new string(s.Distinct().ToArray());
        }
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int tam = b;
                b = a % b;
                a = tam;
            }
            return a;
        }
        static string DecimalTobinary(int n)
        {
            string ans = "";
            if (n == 0) return "0";
            while (n!=0)
            {
                int tam = n % 2;
                ans = ans + tam;
                n = n / 2;
               
            }
            char[] charArr = ans.ToString().ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);


        }
        static bool KiemtraNamNhuan(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 4 == 0 && year % 100 != 0)
                return true;
            return false;
        }
        static int Demsotu(string sentence)
        {
            string[] arr = sentence.Split(' ');
            return arr.Length;
        }
        public static void Main(string[] args)
        {
            //Bai 1: Tinh tong hai so nguyen
            Console.WriteLine("Nhap vao hai so a va b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {TinhTong(a, b)}");
            Console.WriteLine("\n");

            //Bai 2: Kiem tra so chan le
            Console.WriteLine("Nhap vao so de check");
            int n = int.Parse(Console.ReadLine());
            if (KiemTraChanLe(n))
                Console.WriteLine($"{n} la so chan");
            else
                Console.WriteLine($"{n} la so le");
            Console.WriteLine("\n");

            //Bai 3: Tim so lon nhat trong ba so
            Console.WriteLine("Nhap vao ba so x y z");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine($"So lon nhat trong ba so: {TimMax(x, y, z)}");
            Console.WriteLine("\n");

            //Bai 4: Tinh giai thua cua mot so
            Console.WriteLine("Nhap vao m");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine($"{m}! = {TinhGiaiThua(m)}");
            Console.WriteLine("\n");

            //Bai 5: Dao nguoc chuoi ky tu
            Console.WriteLine("Nhap vao chuoi ky tu");
            string s = Console.ReadLine();
            Console.WriteLine($"Chuoi dao nguoc: {DaoNguocChuoi(s)}");
            Console.WriteLine("\n");

            //Bai 6: Kiem tra so nguyen to
            Console.WriteLine("Nhap vao mot so de ktra snto");
            int k = int.Parse(Console.ReadLine());
            if (KiemTraNguyenTo(k))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            //Bai 7: In day Fibonacci
            Console.WriteLine("Nhap vao T - T so dau tien cua day Fibonacci");
            int T = int.Parse(Console.ReadLine());
            InFibonacci(T);
            Console.WriteLine("\n");

            //Bai 8: Dem so luong nguyen am trong chuoi
            Console.WriteLine("Nhap vao chuoi ky tu");
            string s1 = Console.ReadLine();
            Console.WriteLine($"So luong ky tu nguyen am : {DemNguyenAm(s1)}");
            Console.WriteLine("\n");

            //Bai 9: Tinh luy thua
            Console.WriteLine("Nhap vao hai so x1 y1");
            double x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"x^y = {TinhLuyThua(x1, y1)}");

            //Bai 10: Tinh diem trung binh cua mang
            Console.WriteLine("Nhap vao 1 mang:");
            string s2 = Console.ReadLine();
            string[] s3 = s2.Split(',');
            int[] arr = new int[s3.Length];
            for (int i = 0; i < s3.Length; i++)
                arr[i] = int.Parse(s3[i]);
            Console.WriteLine($"Gia tri trung binh cua mang: {TinhTrungbinh(arr)}");
            Console.WriteLine("\n");

            //Bai 11: Kiem tra tinh doi xung
            string s4 = Console.ReadLine();
            if (KiemTraDoiXung(s4))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine("\n");

            //Bai 12: Chuyen doi nhiet do
            Console.WriteLine("Nhap vao do C:");
            double Do_C = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Do_C} do C = {CelsiusToFahrenheit(Do_C)} do F");
            Console.WriteLine("\n");

            //Bai 13: Tim gia tri nho nhat trong mang            
            Console.WriteLine("Nhap vao n - kich thuoc cua mang");
            int n_13 = int.Parse(Console.ReadLine());
            int[] B = new int[n_13];
            Console.WriteLine("Nhap cac phan tu");
            for (int i = 0; i < n_13; i++)
                B[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Gia tri Min cua mang : {TimMin(B)}");
            Console.WriteLine("\n");

            //Bai 14: Tinh tong cac chu so cua mot so nguyen
            Console.WriteLine("Nhap vao mot so nguyen");
            int n_14 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tong cac chu so cua {n_14} : {TongCacChuSo(n_14)}");
            Console.WriteLine("\n");

            //Bai 15: Sap xep mang tang dan
            Console.WriteLine("Nhap vao n - kich thuoc cua mang");
            int n_15 = int.Parse(Console.ReadLine());
            int[] C = new int[n_15];
            Console.WriteLine("Nhap cac phan tu");
            for (int i = 0; i < n_15; i++)
                C[i] = int.Parse(Console.ReadLine());
            SapXepMang(C);
            Console.WriteLine("\n");

            //Bai 16: Xoa ki tu trung lap
            Console.WriteLine("Nhap vao 1 chuoi ky tu");
            string s_16 = Console.ReadLine();
            Console.WriteLine($"Chuoi ky tu sau khi xoa ki tu trung: {XoaTrungLap(s_16)}");
            Console.WriteLine("\n");

            //Bai 17: Tim UCLN
            Console.WriteLine("Nhap vao hai so a b");
            int a_17 = int.Parse(Console.ReadLine());
            int b_17 = int.Parse(Console.ReadLine());
            Console.WriteLine($"UCLN cua {a_17} va {b_17} : {UCLN(a_17, b_17)}");
            Console.WriteLine("\n");

            //Bai 18:Chuyen do he thap phan sang nhi phan
            Console.WriteLine("Nhap vao n - he thap phan");
            int n_18 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n_18} chuyen sang nhi phan la : {DecimalTobinary(n_18)}");
            Console.WriteLine("\n");

            //Bai 19: Kiem tra nam nhuan
            int n_19 = int.Parse(Console.ReadLine());
            if (KiemtraNamNhuan(n_19))
                Console.WriteLine($"{n_19} la nam nhuan ");
            else
                Console.WriteLine($"{n_19} khong la nam nhuan ");
            Console.WriteLine("\n");

            //Bai 20:Dem so tu trong cau
            string s_20 = Console.ReadLine();
            Console.WriteLine($"So luong tu co trong cau : {Demsotu(s_20)}");






            Console.ReadKey();

        }

    }
}
