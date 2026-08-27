using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CSLT.Session_03
{
    internal class Ex_FileBT
    {
        static void Bai01()
        {
            int sodiencu, sodienmoi;
            do
            {
                string input_01 = Console.ReadLine();
                string input_02 = Console.ReadLine();
                if (int.TryParse(input_01, out sodiencu) && int.TryParse(input_02, out sodienmoi))
                {
                    if (sodienmoi < sodiencu)
                        Console.WriteLine("So dien moi phai lon hon so dien cu, vui long nhap lai!");               
                    else
                        break;                    
                }
                else
                    Console.WriteLine("Ban nhap sai dinh dang, vui long nhap lai!");

            } while (true);
            int tieuthu = sodienmoi - sodiencu;
            Console.WriteLine($"So dien tieu thu: {tieuthu} kWh");
            decimal totalbefortax = 0m;
            if (tieuthu > 300)
            {
                totalbefortax += (tieuthu - 300) * 3.050m;
                tieuthu = 300;
            }
            if (tieuthu > 200)
            {
                totalbefortax += (tieuthu - 200) * 2.729m;
                tieuthu = 200;
            }     
            if (tieuthu > 100)
            {
                totalbefortax += (tieuthu - 100) * 2.167m;
                tieuthu = 100;
            }            
            if (tieuthu > 50)
            {
                totalbefortax += (tieuthu - 50) * 1.866m;
                tieuthu = 50;
            }           
            totalbefortax += tieuthu * 1.806m;
            Console.WriteLine($"Tong tien truoc thue: {totalbefortax:f2} VND");
            decimal tax = totalbefortax * 0.08m;
            Console.WriteLine($"Tien thue: {tax:f2} VND");
            Console.WriteLine($"Tong thanh toán: {totalbefortax + tax:f2} VND");

            Console.WriteLine("\n");
        }

        static void Bai02()
        {
            double chieucao, cannang, bmi;
            Console.WriteLine("Chieu cao (m):");
            Console.WriteLine("Can nang (kg):");
            chieucao = double.Parse(Console.ReadLine());
            cannang = double.Parse(Console.ReadLine());
            bmi = cannang / Math.Pow(chieucao, 2);
            Console.WriteLine($"Chi so BMI cua ban: {bmi:F2}");
            if (bmi < 18.5)
                Console.WriteLine("Phan loai suc khoe : Gay (Thieu can)");
            else if (18.5 <= bmi && bmi < 23.0)
                Console.WriteLine("Phan loai suc khoe : Binh thuong (Ly tuong)");
            else if (23.0 <= bmi && bmi < 25.0)
                Console.WriteLine("Phan loai suc khoe : Thua can (Tien beo phi)");
            else Console.WriteLine("Phan loai suc khoe : Beo phi");
            Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu {(18.5 * Math.Pow(chieucao, 2)):F2}kg den {(22.9 * Math.Pow(chieucao, 2)):F2}kg.");

            Console.WriteLine("\n");


        }
        static void Bai03()
        {
            decimal tien_VND, tam;
            byte ngoaite;
            Console.WriteLine("Nhap so tien VND:");
            tien_VND = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Chon ngoai te (1-USD, 2-EUR, 3-JPY, 4-GBP)");
            ngoaite = byte.Parse(Console.ReadLine());
            Console.WriteLine($"Phi dich vu (0.5%): {(tien_VND * 0.5M / 100):N0}");
            Console.WriteLine($"So tien VND tinh doi: {(tien_VND - tien_VND * 0.5M / 100):N0}");
            tam = tien_VND - tien_VND * 0.5M / 100;
            switch(ngoaite)
            {
                case 1:
                    {
                        Console.WriteLine($"So tien USD nhan duoc: {(tam / 25400M):F2} USD");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"So tien EUR nhan duoc: {(tam / 27200M):F2} EUR");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"So tien JPY nhan duoc: {(tam / 165M):F2} JPY");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"So tien GBP nhan duoc: {(tam / 32100M):F2} GBP");
                        break;
                    }
                }
            Console.WriteLine("\n");
        }
        static void Bai04()
        {
            Console.WriteLine("Nhap ngay sinh (dd/MM/yyyy):");         
            string format = "dd/MM/yyyy";
            DateTime dataResult;
            do
            {
                string input = Console.ReadLine();
                if (DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataResult))
                    break;
                else
                {
                    Console.WriteLine("Ban nhap sai dinh dang, Vui long nhap lai!");
                }
            } while (true);
            DateTime today = DateTime.Today;
            int age = today.Year - dataResult.Year;
            if (today < dataResult.AddYears(age))
            {
                --age;
                Console.WriteLine($"Tuoi hien tai: {age}");
            }
            TimeSpan livedTime = today - dataResult;
            int totaldayslived = (int)livedTime.TotalDays;
            DateTime nextbirthday = new DateTime(today.Year, dataResult.Month, dataResult.Day);
            if (nextbirthday < today)
                nextbirthday = nextbirthday.AddYears(1);
            int daysuntilnextbirthday = (int)(nextbirthday - today).TotalDays;
            Console.WriteLine($"Ban da song tong cong: {totaldayslived:N0}");
            Console.WriteLine($"Sinh nhat tiep theo con: {daysuntilnextbirthday}");

            Console.WriteLine("\n");

        }
        enum Xeploai
        {
            XuatSac,
            Gioi,
            Kha,
            Trungbinh,
            Yeu,
            Kem
        }
        static void Bai05()
        { 
            double diem_LT, diem_Toan, diem_TA, Score_Avg;
            int sotin_LT, sotin_Toan, sotin_TA;
            char diemchu;
            float thang_4;
            Xeploai loai;
            Console.WriteLine("so diem mon C#:");
            diem_LT = double.Parse(Console.ReadLine());
            Console.WriteLine("so tin mon C#");
            sotin_LT = int.Parse(Console.ReadLine());
            Console.WriteLine("so diem mon Toan:");
            diem_Toan = double.Parse(Console.ReadLine());
            Console.WriteLine("so tin mon Toan");
            sotin_Toan = int.Parse(Console.ReadLine());
            Console.WriteLine("so diem mon Tieng anh:");
            diem_TA = double.Parse(Console.ReadLine());
            Console.WriteLine("so tin mon Tieng anh:");
            sotin_TA = int.Parse(Console.ReadLine());
            Score_Avg = (diem_LT * sotin_LT + diem_Toan * sotin_Toan + diem_TA * sotin_TA) / (sotin_LT + sotin_Toan + sotin_TA);
            if (8.5 <= Score_Avg && Score_Avg <= 10.0)
            {
                diemchu = 'A';
                thang_4 = 4.0f;
                loai = Xeploai.XuatSac;
            }
            else if (7.0 <= Score_Avg && Score_Avg <= 8.4)
            {
                diemchu = 'B';
                thang_4 = 3.0f;
                loai = Xeploai.Kha;
            }
            else if (5.5 <= Score_Avg && Score_Avg <= 6.9)
            {
                diemchu = 'C';
                thang_4 = 2.0f;
                loai = Xeploai.Trungbinh;
            }
            else if (4.0 <= Score_Avg && Score_Avg <= 5.4)
            {
                diemchu = 'D';
                thang_4 = 1.0f;
                loai = Xeploai.Yeu;
            }
            else
            {
                diemchu = 'F';
                thang_4 = 0.0f;
                loai = Xeploai.Kem;
            }
            Console.WriteLine($"| {"Diem TB thang 10",-20} : {Score_Avg,8:F2} |");
            Console.WriteLine($"| {"Diem chu quy doi",-20} : {diemchu,8} |");
            Console.WriteLine($"| {"Diem GPA thang 4",-20} : {thang_4,8:F1} |");
            Console.WriteLine($"| {"Xep loai hoc luc",-20} : {loai,8} |");
            Console.WriteLine("=======================================");
            Console.WriteLine("\n");

        }
        static void Bai06()
        {
            string ho_ten_tho = Console.ReadLine();
            string result_hoten = ho_ten_tho.Trim();
            string tam = "",ho_ten_chuan_hoa = "", tendem = "";
            string[] words = result_hoten.Split(' ');           
            for (int i = 0; i < words.Length; i++)
            {
                string firstLetter = words[i].Substring(0, 1);
                string restLetter = words[i].Substring(1);              
                firstLetter = firstLetter.ToUpper();
                restLetter = restLetter.ToLower();
                words[i] = firstLetter + restLetter;
                ho_ten_chuan_hoa += words[i];
                if (i < words.Length-1)
                {
                    tam = tam + words[i];
                    ho_ten_chuan_hoa += ' ';
                }
                if (i != 0 && i != words.Length - 1)              
                    tendem += words[i];                   
            }
            string userName = words[words.Length - 1].ToLower() +'.'+ tam.ToLower();
            Console.WriteLine($"Ho te chuan hoa: {ho_ten_chuan_hoa}");
            Console.WriteLine($"{"Ho",-5} : {words[0],8} | {"Ten Dem",-5} : {tendem,8} | {"Ten",-5} : {words[words.Length-1],8}");
            Console.WriteLine($"UserName tao tu dong : {userName}");
            Console.WriteLine($"Email cap phat: {userName + "@company.edu.vn"}");

            Console.WriteLine("\n");


        }
        
        static void Bai07()
        {
            double khoangcach, muctieuthu;
            decimal giaxang_hientai;
            int solgnguoi;
            Console.WriteLine("Quang duong (km):");
            khoangcach = double.Parse(Console.ReadLine());
            Console.WriteLine("Muc tieu hao (L/100km):");
            muctieuthu = double.Parse(Console.ReadLine());
            Console.WriteLine("Gia xang (VND/L):");
            giaxang_hientai = decimal.Parse(Console.ReadLine());
            Console.WriteLine("So nguoi di:");
            solgnguoi = int.Parse(Console.ReadLine());
            double total_nhienlieu_tieuthu = khoangcach / 100 * muctieuthu;
            decimal total_cost = Math.Floor((decimal)(total_nhienlieu_tieuthu) * giaxang_hientai);
            decimal cost_per = Math.Ceiling((total_cost / solgnguoi )/ 1000M) * 1000M;
            Console.WriteLine($"Tong nhien lieu tieu thu: {total_nhienlieu_tieuthu:F2} Lit");
            Console.WriteLine($"Tong chi phi xang dau: {total_cost:N0} VND");
            Console.WriteLine($"Chi phi moi nguoi: {cost_per} VND");

            Console.WriteLine("\n");


        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Bai01();
            Bai02();
            Bai03();
            Bai04();
            Bai05();
            Bai06();
            Bai07();
            Console.ReadKey();
        }
    }
}
