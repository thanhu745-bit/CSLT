using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.Session_07
{
    internal class Ex_01_Nop
    {
        static void Print_str(string s)
        {
            Console.WriteLine(s);            
        }
        static int FindLength(string s)
        {
            int dem = 0;
            foreach (char c in s)
                ++dem;
            return dem;
        }
        static void Separate(string s)
        {
            for (int i = 0; i < s.Length; i++)
                Console.Write($"{s[i]} ");

        }
        static void Print_reverse(string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
                Console.Write($"{s[i]} ");
        }
        static int Count_words(string s)
        {
            string[] A = s.Split();
            return A.Length;
        }
        static bool Compare_2String(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i]) return false;
            }
            return true;
        }
        static (int count_al, int count_di, int count_character) Count(string s)
        {
            int count_al = 0;
            int count_di = 0;
            int count_character = 0;
            foreach (char c in s)
            {
                if ('0' <= c && c <= '9')
                    ++count_di;
                if ('a' <= c && c <= 'z')
                    ++count_al;
                if ('A' <= c && c <= 'Z')
                    ++count_al;

            }
            count_character = s.Length - count_di - count_al;
            return (count_al, count_di, count_character);
        }
        static (int vowels , int consonats) Count_vo_con(string s)
        {
            int vowels = 0;
            int consonats = 0;
            foreach (char c in s)
            {
                if (char.IsLetter(c))
                {
                    if (c == 'u' || c == 'e' || c == 'o' || c == 'a' || c == 'i')
                        ++vowels;
                    else if (c == 'U' || c == 'E' || c == 'O' || c == 'A' || c == 'I')
                        ++vowels;
                    else
                        ++consonats;
                }

            }
            
            return (vowels, consonats);
        }
        static bool Check_substring(string s, string sub)
        {
            return s.Contains(sub);
        }
        static int Search_position_substring(string s, string sub)
        {
            return s.IndexOf(sub);
        }
        static byte thecase_alphabet(char c)
        {
            //1 - Upper ; 2 - Lower
            if (char.IsUpper(c))
                return 1;
            return 2;
        }
        static string Insert(string s, string sub, string value)
        {
            int index = s.IndexOf(sub);
            s = s.Insert(index, value);
            return s;
        }
        static int find_sub_appear(string s, string sub)
        {
            int dem = 0,index = 0;

            while (s.IndexOf(sub,index) != -1)
            {
                ++dem;
                index = s.IndexOf(sub,index) + 1;
            }
            return dem;
        }
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //-to input a string and print it.
            Print_str(input);
            Console.WriteLine("\n");

            //-to find the length of a string without using a library function.
            Console.WriteLine($"Do dai cua chuoi la: {FindLength(input)}");
            Console.WriteLine("\n");

            //-to separate individual characters from a string.
            Separate(input);
            Console.WriteLine("\n");

            //-to print individual characters of the string in reverse order.
            Print_reverse(input);
            Console.WriteLine("\n");

            //-to count the total number of words in a string.
            Console.WriteLine($"Total number of words: {Count_words(input)}");
            Console.WriteLine("\n");

            //-to compare two strings without using a string library functions.
            Console.WriteLine("Nhap chuoi thu 2");
            string input2 = Console.ReadLine();
            if (Compare_2String(input, input2))
                Console.WriteLine("Hai chuoi giong nhau");
            else
                Console.WriteLine("Hai chuoi khac nhau");
            Console.WriteLine("\n");

            //-to count the number of alphabets, digits, and special characters in a string
            Console.WriteLine($"The number of alphabets, digits, and special characters: {Count(input)} ");
            Console.WriteLine("\n");

            //-to count the number of vowels or consonants in a string.
            Console.WriteLine($"The number of vowels or consonants: {Count_vo_con(input)}");
            Console.WriteLine("\n");

            //-to check whether a given substring is present in the given string
            Console.WriteLine("Nhap vao chuoi con de kiem tra");
            string substring = Console.ReadLine();
            if (Check_substring(input, substring))
                Console.WriteLine($"{substring} co chua trong {input}");
            else
                Console.WriteLine($"{substring} khong chua trong {input}");
            Console.WriteLine("\n");

            //-to search for the position of a substring within a string.
            if (Search_position_substring(input, substring) == -1)
                Console.WriteLine($"{substring} khong chua trong {input}");
            else
                Console.WriteLine($"{substring} xuat hien tai {Search_position_substring(input, substring)}");
            Console.WriteLine("\n");

            //-to check whether a character is an alphabet and not and if so, check for the case.
            Console.WriteLine("Nhap vao 1 ky tu");
            char c = char.Parse(Console.ReadLine());
            if (char.IsLetter(c))
            {
                if (thecase_alphabet(c) == 1)
                    Console.WriteLine($"{c} la chu cai va la chu hoa");
                else if (thecase_alphabet(c) == 2)
                    Console.WriteLine($"{c} la chu cai va la chu thuong");
            }
            else
                Console.WriteLine($"{c} khong la chu cai");
            Console.WriteLine("\n");

            //-to find the number of times a substring appears in a given string.
            Console.WriteLine($"{substring} xuat hien trong {input} : {find_sub_appear(input, substring)} lan");
            Console.WriteLine("\n");

            //-to insert a substring before the first occurrence of a string.
            string valuetoInsert = "Uyen ";
            Console.WriteLine($"Chuoi sau khi chen la: {Insert(input, substring, valuetoInsert)}");

            Console.ReadKey();
            
        }
    }
}
