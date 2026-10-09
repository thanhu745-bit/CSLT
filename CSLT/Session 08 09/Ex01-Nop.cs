using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace CSLT.Session_08_09
{
    internal class Ex01_Nop
    {
        //1.to create a blank file on the disk.
        static void CreateBlankFile(string filePath)
        {
            File.Create(filePath).Close();
            Console.WriteLine($"Da tao tep rong ten la: {filePath}");
        }
        //2.to remove a file from the disk.
        static void RemoveFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine($"Da xoa tep ten la :{filePath}");

            }
            else
                Console.WriteLine($"{filePath} khong ton tai");
        }
        //3.to create a file and add some text.
        static void Createandaddtext(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine($"Da tao tep {filePath} va ghi noi dung {content}");
        }
        //4.create a text file and read it.
        public static void CreateAndReadFile(string filePath, string content)
        {
            Createandaddtext(filePath, content);
            string readContent = File.ReadAllText(filePath);
            Console.WriteLine($"Nội dung đọc từ {filePath}:\n{readContent}");
        }

        // 5. Tạo một tệp và ghi một mảng chuỗi vào tệp
        public static void WriteStringArrayToFile(string filePath, string[] lines)
        {
            File.WriteAllLines(filePath, lines);
            Console.WriteLine($"Đã ghi mảng chuỗi vào tệp: {filePath}");
        }

        // 6. Nối thêm (append) nội dung văn bản vào tệp hiện có
        public static void AppendTextToFile(string filePath, string extraText)
        {
            File.AppendAllText(filePath, extraText);
            Console.WriteLine($"Đã nối thêm văn bản vào tệp: {filePath}");
        }

        // 7. Tạo, sao chép tệp sang tên khác và hiển thị nội dung tệp mới
        public static void CreateCopyAndDisplay(string sourcePath, string destPath, string content)
        {
            File.WriteAllText(sourcePath, content);
            File.Copy(sourcePath, destPath, overwrite: true);

            string copiedContent = File.ReadAllText(destPath);
            Console.WriteLine($"Nội dung tệp sao chép ({destPath}):\n{copiedContent}");
        }

        // 8. Tạo một tệp và di chuyển (đổi tên) trong cùng thư mục
        public static void CreateAndMoveFile(string sourcePath, string newPath)
        {
            File.WriteAllText(sourcePath, "Nội dung ban đầu");
            if (File.Exists(newPath)) File.Delete(newPath); // Xóa tệp cũ nếu đã tồn tại
            File.Move(sourcePath, newPath);
            Console.WriteLine($"Đã đổi tên/di chuyển tệp từ {sourcePath} sang {newPath}");
        }

        // 9. Đọc dòng đầu tiên của tệp
        public static void ReadFirstLine(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine($"Dòng đầu tiên: {firstLine}");
                }
            }
        }

        // 10. Tạo tệp và đọc dòng cuối cùng của tệp
        public static void CreateAndReadLastLine(string filePath, string[] lines)
        {
            File.WriteAllLines(filePath, lines);
            string[] allLines = File.ReadAllLines(filePath);
            if (allLines.Length > 0)
            {
                Console.WriteLine($"Dòng cuối cùng: {allLines[allLines.Length - 1]}");
            }
        }

        // 11. Tạo tệp và đọc n dòng cuối cùng của tệp
        public static void CreateAndReadLastNLines(string filePath, string[] lines, int n)
        {
            File.WriteAllLines(filePath, lines);
            string[] allLines = File.ReadAllLines(filePath);

            var lastNLines = allLines.Skip(Math.Max(0, allLines.Length - n));
            Console.WriteLine($"{n} dòng cuối cùng:");
            foreach (var line in lastNLines)
            {
                Console.WriteLine(line);
            }
        }

        // 12. Đọc một dòng cụ thể (dòng thứ lineIndex, tính từ 1) từ tệp
        public static void ReadSpecificLine(string filePath, int lineIndex)
        {
            string[] allLines = File.ReadAllLines(filePath);
            if (lineIndex >= 1 && lineIndex <= allLines.Length)
            {
                Console.WriteLine($"Dòng {lineIndex}: {allLines[lineIndex - 1]}");
            }
            else
            {
                Console.WriteLine($"Tệp không có dòng thứ {lineIndex}.");
            }
        }

        // 13. Đếm số dòng trong tệp
        public static void CountLinesInFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                int lineCount = File.ReadAllLines(filePath).Length;
                Console.WriteLine($"Số dòng trong tệp: {lineCount}");
            }
        }

        // 14. In cấu trúc thư mục (bao gồm tất cả các tệp bên trong)
        public static void PrintFolderStructure(string folderPath, string indent = "")
        {
            if (!Directory.Exists(folderPath)) return;

            DirectoryInfo dir = new DirectoryInfo(folderPath);
            Console.WriteLine($"{indent}[Thư mục] {dir.Name}");

            // In các tệp trong thư mục
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine($"{indent}  ├── [File] {file.Name}");
            }

            // Đệ quy in các thư mục con
            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                PrintFolderStructure(subDir.FullName, indent + "  ");
            }
        }

        // 15. Đọc tệp văn bản, thống kê tần suất xuất hiện của ký tự & số + lưu vị trí (Jagged Array)
        public static void StatisticCharactersAndNumbers(string filePath)
        {
            if (!File.Exists(filePath)) return;

            string[] lines = File.ReadAllLines(filePath);
            int[,] charCounts = new int[256, 2];
            for (int i = 0; i < 256; i++)
            {
                charCounts[i, 0] = i; // Mã ASCII
                charCounts[i, 1] = 0; // Số lần xuất hiện
            }
            for (int row = 0; row < lines.Length; row++)
            {
                for (int col = 0; col < lines[row].Length; col++)
                {
                    char c = lines[row][col];
                    if (c < 256)
                    {
                        charCounts[c, 1]++;
                    }
                }
            }
            int[][] positions = new int[256][];
            for (int i = 0; i < 256; i++)
            {
                if (charCounts[i, 1] > 0)
                {
                   positions[i] = new int[charCounts[i, 1] * 2];
                }
            }

           
            int[] currentIndices = new int[256];
            for (int row = 0; row < lines.Length; row++)
            {
                for (int col = 0; col < lines[row].Length; col++)
                {
                    char c = lines[row][col];
                    if (c < 256 && char.IsLetterOrDigit(c))
                    {
                        int idx = currentIndices[c];
                        positions[c][idx] = row + 1;     
                        positions[c][idx + 1] = col + 1; 
                        currentIndices[c] += 2;
                    }
                }
            }
            for (int i = 0; i < 256; i++)
            {
                char c = (char)charCounts[i, 0];
                int count = charCounts[i, 1];

                if (char.IsLetterOrDigit(c) && count > 0)
                {
                    Console.WriteLine($"Ký tự '{c}': xuất hiện {count} lần.");
                    Console.Write("  Vị trí (dòng, cột): ");

                    for (int k = 0; k < positions[i].Length; k += 2)
                    {
                        int r = positions[i][k];
                        int col = positions[i][k + 1];
                        Console.Write($"({r},{col}) ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void Main(string[] args)
        {
            // 1. Tạo tệp rỗng
            CreateBlankFile("test.txt");
            // 2. Xóa tệp
            RemoveFile("test.txt");
            // 3. Tạo tệp và ghi văn bản
            string s = "Hello World!";
            string filename = "test_ex09.txt";
            Createandaddtext(filename, s);
            // 4. Tạo tệp và ghi văn bản
            CreateAndReadFile(filename, s);
            // 5. Tạo tệp và ghi mảng chuỗi
            string[] sampleLines = new string[] {"Dong 1: Hello World 123","Dong 2: C# Programming","Dong 3: Bai tap 09"};
            WriteStringArrayToFile("test_ex05.txt", sampleLines);
            // 6. Nối văn bản vào tệp hiện có
            AppendTextToFile("test_ex05.txt", "\nDong 4: Append text");
            // 7. Tạo, sao chép tệp và hiển thị nội dung
            CreateCopyAndDisplay("test_ex07.txt", "test_ex07_copy.txt", "Noi dung file goc 07");
            // 8. Tạo và di chuyển (đổi tên) tệp
            CreateAndMoveFile("test_ex08_old.txt", "test_ex08_new.txt");
            // 9. Đọc dòng đầu tiên
            ReadFirstLine("test_ex05.txt");
            // 10. Tạo tệp và đọc dòng cuối cùng
            CreateAndReadLastLine("test_ex10.txt", sampleLines);
            // 11. Tạo tệp và đọc N dòng cuối cùng
            CreateAndReadLastNLines("test_ex11.txt", sampleLines, 2);
            // 12. Đọc một dòng cụ thể (ví dụ: dòng thứ 2)
            ReadSpecificLine("test_ex05.txt", 2);
            // 13. Đếm số dòng trong tệp
            CountLinesInFile("test_ex05.txt");
            // 14. In cấu trúc thư mục hiện tại
            Console.WriteLine("--- CAU TRUC THU MUC ---");
            PrintFolderStructure(Directory.GetCurrentDirectory());



        }
    }
}
