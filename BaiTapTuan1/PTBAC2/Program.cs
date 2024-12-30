using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Chương trình giải phương trình bậc hai: ax² + bx + c = 0\n");

        while (true)
        {
            double a = NhapHeSo("Nhập hệ số a (a ≠ 0): ");
            if (a == double.MinValue) break; 

            double b = NhapHeSo("Nhập hệ số b: ");
            if (b == double.MinValue) break; 

            double c = NhapHeSo("Nhập hệ số c: ");
            if (c == double.MinValue) break; 

            GiaiPhuongTrinhBacHai(a, b, c);

            Console.WriteLine("\n--- Nhấn 'K' để thoát hoặc tiếp tục nhập hệ số mới ---\n");
        }

        Console.WriteLine("Chương trình đã kết thúc.");
    }

    static double NhapHeSo(string thongBao)
    {
        while (true)
        {
            Console.Write(thongBao);

            string input = Console.ReadLine();
            if (input.ToUpper() == "K") return double.MinValue; 

            if (double.TryParse(input, out double ketQua))
            {
                return ketQua; // Đầu vào hợp lệ
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
            }
        }
    }

    static void GiaiPhuongTrinhBacHai(double a, double b, double c)
    {
        Console.WriteLine($"\nGiải phương trình: {a}x² + {b}x + {c} = 0");

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Phương trình có hai nghiệm phân biệt:\n  x1 = {x1}\n  x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Phương trình có nghiệm kép:\n  x = {x}");
        }
        else
        {
            Console.WriteLine("Phương trình vô nghiệm (Delta < 0).");
        }
    }
}
