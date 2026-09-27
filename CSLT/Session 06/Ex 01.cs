using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            return (double)sum / arr.Length;
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
        static (int Max_value, int Min_value) MaxMin_value(int[] arr)
        {
            int Max_value = int.MinValue;
            int Min_value = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max_value)
                    Max_value = arr[i];
                if (arr[i] < Min_value)
                    Min_value = arr[i];
            }
            return (Max_value, Min_value);
        }
        static void ReverseArr(int[] arr)
        {
            int[] ans = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                ans[j] = arr[i];
                ++j;
            }
            for (int i = 0; i < ans.Length; i++)
                Console.Write($"{ans[i]} ");
            Console.WriteLine("");
        }
        static void FindDuplicate(int[] arr)
        {
            Console.Write("Duplicate values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i] + " ");
                        break;
                    }
                }
            }
        }
        static void RemoveDuplicate(int[] arr)
        {
            int[] result = new int[arr.Length];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool duplicate = false;

                for (int j = 0; j < count; j++)
                {
                    if (arr[i] == result[j])
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (!duplicate)
                {
                    result[count] = arr[i];
                    count++;
                }
            }

            int[] newArr = new int[count];

            for (int i = 0; i < count; i++)
                newArr[i] = result[i];

            for (int i = 0; i < count; i++)
                Console.Write($"{newArr[i]} ");
        }
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine("");
        }
        static int LinearSearch(string[] arr, string word)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }
        static void PrintRowAndCol(int[,] matrix, int i)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // In hàng i
            if (i >= 0 && i < rows)
            {
                Console.Write($"Hang thu {i}: ");
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(matrix[i, c] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Chi so i = {i} nam ngoai pham vi hang (0 -> {rows - 1}).");
            }
        }
        static int FindMax(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int max = matrix[0, 0];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r, c] > max)
                    {
                        max = matrix[r, c];
                    }
                }
            }
            return max;
        }
        static void FindMinOfRowAndCol(int[,] matrix, int i)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Min hàng i
            if (i >= 0 && i < rows)
            {
                int minRow = matrix[i, 0];
                for (int c = 1; c < cols; c++)
                {
                    if (matrix[i, c] < minRow) minRow = matrix[i, c];
                }
                Console.WriteLine($"Gia tri nho nhat (Min) cua hang {i}: {minRow}");
            }

            // Min cột i
            if (i >= 0 && i < cols)
            {
                int minCol = matrix[0, i];
                for (int r = 1; r < rows; r++)
                {
                    if (matrix[r, i] < minCol) minCol = matrix[r, i];
                }
                Console.WriteLine($"Gia tri nho nhat (Min) cua cot {i}: {minCol}");
            }
        }
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transpose = new int[cols, rows];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    transpose[c, r] = matrix[r, c];
                }
            }
            return transpose;
        }
        static void PrintDiagonals(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (rows == cols)
            {
                Console.Write("Duong cheo chinh: ");
                for (int k = 0; k < rows; k++)
                {
                    Console.Write(matrix[k, k] + " ");
                }
                Console.WriteLine();

                Console.Write("Duong cheo phu: ");
                for (int k = 0; k < rows; k++)
                {
                    Console.Write(matrix[k, rows - 1 - k] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Khong the in duong cheo vi day khong phai ma tran vuong.");
            }
        }
       
        
    

        public static void Main(string[] args)
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
            Console.WriteLine($"Gia tri Max, Min la: {MaxMin_value(numbers)}");
            Console.WriteLine("\n");

            //6.to reverse an array of integer values.
            ReverseArr(numbers);
            Console.WriteLine("\n");

            //7.to find duplicate values in an array of values.
            FindDuplicate(numbers);
            Console.WriteLine("\n");

            //8.to remove duplicate elements from an array.
            RemoveDuplicate(numbers);
            Console.WriteLine("\n");

            //9. requests 10 integers from the user and orders them by implementing the bubble sort algorithm.
            Console.WriteLine("Nhap vao size cua new_arr");
            int m = int.Parse(Console.ReadLine());
            int[] new_numbers = new int[m];
            for (int i = 0; i < m; i++)
                new_numbers[i] = int.Parse(Console.ReadLine());
            BubbleSort(new_numbers);
            Console.WriteLine("\n");

            //10.Search if the word appears in the phrase using the linear search algorithm.
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();
            string[] words = sentence.Split(' ');
            int ans = LinearSearch(words, word);
            if (ans != -1)
            {
                Console.WriteLine($"{word} co xuat hien");
            }
            else
            {
                Console.WriteLine($"{word} khong co xuat hien");
            }
            Console.WriteLine("\n");

            //11. Matrix
            Console.Write("Nhap so hang N_Matrix: ");
            int n_matrix = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot M_Matrix: ");
            int m_matrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n_matrix, m_matrix];
            for (int r = 0; r < n_matrix; r++)
            {
                for (int c = 0; c < m_matrix; c++)
                {
                    matrix[r, c] = rand.Next(1, 100);
                }
            }
            for (int r = 0; r < n_matrix; r++)
            {
                for (int c = 0; c < m_matrix; c++)
                {
                    Console.Write($"{matrix[r, c]}");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Nhap vao ith row");
            int i_row_col = int.Parse(Console.ReadLine());
            PrintRowAndCol(matrix, i_row_col);
            Console.WriteLine("");
            Console.WriteLine($"Gia tri lon nhat cua ma tran la:{FindMax(matrix)}");
            Console.WriteLine("");
            FindMinOfRowAndCol(matrix, i_row_col);
            Console.WriteLine("");
            int[,] new_matrix = new int[n_matrix, m_matrix];
            new_matrix = TransposeMatrix(matrix);
            for (int r = 0; r < new_matrix.GetLength(0); r++)
            {
                for (int c = 0; c < new_matrix.GetLength(1); c++)
                {
                    Console.Write($"{new_matrix[c, r]} ");
                }

                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("DUONG CHEO MA TRAN");
            PrintDiagonals(matrix);


        }
    }
}
