using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.Session_04
{
    internal class Ex_01
    {
        static void BT1()
        {
            //Write a C# Sharp program that takes two numbers as input and performs an operation(+, -, *, x,/) on them and displays the result of that operation.
            int num1, num2;
            Console.WriteLine("Nhap so thu nhat: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
        static void BT2()
        {
            //Write a C# Sharp program to display certain values of the function x = y2+2y + 1
            int sum = 0;
            for (int i = -5; i < 5; i++)
            {
                sum = i * i + 2 * i + 1;
                Console.WriteLine($"y = {i}, x = {sum}");
            }
        }
        static void BT3()
        {
            //Write a C# Sharp program that takes distance and time (hours, minutes,
            //seconds) as input and displays speed in kilometers per hour(km / h) and
            //miles per hour(miles/ h).
            short hours, minutes, seconds;
            float distance;
            Console.WriteLine("Nhap quang duong (km): ");
            distance = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gio: ");
            hours = short.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phut: ");
            minutes = short.Parse(Console.ReadLine());
            Console.WriteLine("Nhap giay: ");
            seconds = short.Parse(Console.ReadLine());
            float totalTimeInHours = hours + (float)minutes / 60.0f + (float)seconds / 3600.0f;
            float speedKmPerHour = distance / totalTimeInHours;
            float speedMilesPerHour = speedKmPerHour / 1.609344f;

            Console.WriteLine($"Van toc (km/h): {speedKmPerHour:F2}");
            Console.WriteLine($"Van toc (miles/h): {speedMilesPerHour:F2}");

        }
        static void BT4()
        {
            //Write a C# Sharp program that takes the radius of a sphere as input and
            //calculates and displays the surface and volume of the sphere.
            float radius;
            Console.WriteLine("Nhap ban kinh: ");
            radius = float.Parse(Console.ReadLine());
            Console.WriteLine($"Surface : {(4 * (float)Math.PI * radius * radius)}");
            Console.WriteLine($"Volume : {(4.0f / 3.0f * (float)Math.PI * radius * radius * radius)}");
        }
        static void BT5()
        {
            //Write a C# Sharp program that takes a character as input and checks if it
            //is a vowel, a digit, or any other symbol.
            char inputChar;
            Console.WriteLine("Nhap mot ky tu: ");
            inputChar = char.Parse(Console.ReadLine());
            if ("aeiouAEIOU".IndexOf(inputChar) >= 0)
                Console.WriteLine($"{inputChar} la nguyen am");
            else if ((int)char.GetNumericValue(inputChar) >= 0 && (int)char.GetNumericValue(inputChar) <= 9)
                Console.WriteLine($"{inputChar} la mot chu so");
            else
                Console.WriteLine($"{inputChar} la mot ky tu khac");

        }
        static void GiaiPT(int a, int b, int c)
        {
            if (a==0)
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
                        Console.WriteLine($"Phuong trinh co nghiem x = {-c / b}");
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
                            Console.WriteLine("Vo ly");
                        else
                            Console.WriteLine($"Phuong trinh co nghiem x = {Math.Sqrt(-c / a)} va x = {-Math.Sqrt(-c / a)}");
                    }

                }
                else
                {
                    if (c == 0)
                        Console.WriteLine($"Phuong trinh co nghiem x1 = 0 va x2 = {-b / a}");
                    else
                    {
                        double delta = b * b - 4 * a * c;
                        if (delta < 0)
                            Console.WriteLine("Phuong trinh vo nghiem");
                        else if (delta == 0)
                            Console.WriteLine($"Phuowng trinh co nghiem kep x = {-b / 2 * a}");
                        else
                            Console.WriteLine($"Phuong trinh co nghiem x1 = {(-b + Math.Sqrt(delta)) / (2 * a)} va x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
                        
                    }
                }
            }
               

        }
        public static void Main(string[] args)
        {          
            BT1();         
            BT2();
            BT3();
            BT4();
            BT5();
            Console.WriteLine("Nhap cac he so cua phuong trinh bac 2: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GiaiPT(a, b, c);
            Console.ReadKey();
        }
    }
}
