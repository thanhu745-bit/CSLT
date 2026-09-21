using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace CSLT.Session_06
{
    internal class Ex_01
    {     
        static double Average(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return (double) sum / arr.Length;
        }
        static bool Test_arr(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x) return true;
            return false;
           
        }
        static void Find_index(int[] arr, int x)
        {
            byte bao = 0;
            Console.Write($"Vi tri cua {x} trong mang: ");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == x)
                {
                    Console.Write($"{i + 1} ");
                    bao = 1;
                }
            if (bao == 0)
                Console.WriteLine("Khong ton tai trong mang");

        }
        static void Remove_x(int[] arr, int x)
        {
            int[] ans = new int[arr.Length];
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != x)
                {
                    ans[k] = arr[i];
                    ++k;
                }
            }
            Console.WriteLine("Mang sau khi xoa phan tu dac biet");
            for (int i = 0; i < ans.Length; i++)
                Console.Write($"{ans[i]} ");

        }

        public static void Main1(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(1, 100) + 1;
            for (int i = 0; i < numbers.Length; i++) 
                Console.Write($"{numbers[i]} ");
            Console.WriteLine("");
            //1. to calculate the average value of array elements
            Console.WriteLine($"Gia tri trung binh cua mang: {Average(numbers)}");
            Console.WriteLine("\n");

            //2. to test if an array contains a specific value.
            Console.WriteLine("Nhap vao gia tri dac biet:");
            int x = int.Parse(Console.ReadLine());
            if (Test_arr(numbers, x))
                Console.WriteLine($"Mang co chua gia tri {x}");
            else
                Console.WriteLine($"Mang khong chua gia tri {x}");
            Console.WriteLine("\n");

            //3.to find the index of an array element.
            Find_index(numbers, x);
            Console.WriteLine("\n");

            //4. to remove a specific element from an array.
            Remove_x(numbers, x);
            Console.WriteLine("\n");

            //5.to find the maximum and minimum value of an array.












        }
    }
}
