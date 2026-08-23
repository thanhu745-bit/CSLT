using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.Session_03
{
    internal class Ex_FileBT
    {
        static void Main(string[] args)
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
        }
    }
}
