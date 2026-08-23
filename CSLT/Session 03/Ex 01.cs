using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_03
{
    internal class Ex_01
    {
        static void BT_01()
        {
            do
            {
                string input_ex01 = Console.ReadLine();
                float cel;
                if (float.TryParse(input_ex01, out cel))
                {
                    Console.WriteLine($"Kelvin: {cel + 273.0f:f2}");
                    Console.WriteLine($"Fahrenheit: {(cel * 1.8f + 32):f2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ban nhap sai dinh dang, vui long nhap lai!");
                }
            }
            while (true);
            Console.WriteLine("\n");
        }
        static void BT_02()
        {
            do
            {
                string input_ex2 = Console.ReadLine();
                const float pi = (float)Math.PI;
                float r;
                if (float.TryParse(input_ex2, out r))
                {
                    Console.WriteLine($"Surface: {4 * pi * r * r}");
                    Console.WriteLine($"Volume: {4 / 3 * pi * r * r * r}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ban nhap sai dinh dang, vui long nhap lai!");
                }
            }
            while (true);
            Console.WriteLine("\n");
        }
        static void BT_03()
        {
            Console.Write("Number_01: ");
            string input_ex3_01 = Console.ReadLine();
            Console.Write("Number_02: ");
            string input_ex3_02 = Console.ReadLine();
            float num1 = float.Parse(input_ex3_01);
            float num2 = float.Parse(input_ex3_02);
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} mod {num2} = {num1 % num2}");
        }

        public static void Main3(string[] args)
        {
            Console.WriteLine("Nhap nhiet do (Celsius): ");
            BT_01();
            Console.WriteLine("Nhap ban kinh: ");
            BT_02();
            Console.WriteLine("Nhap hai so: ");
            BT_03();

            Console.ReadKey();
        }
    }

}
