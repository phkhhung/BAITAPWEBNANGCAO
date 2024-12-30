using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Chương trình kiểm tra số nguyên tố.\n");

        while (true)
        {
            int n = NhapSoNguyen("Nhập một số nguyên (≥ 2): ");
            if (n == -1) break; 

            if (LaSoNguyenTo(n))
            {
                Console.WriteLine($"{n} là số nguyên tố.\n");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố.\n");
            }

            Console.WriteLine("--- Nhấn 'K' để thoát hoặc tiếp tục kiểm tra số khác ---\n");
        }

        Console.WriteLine("Chương trình đã kết thúc.");
    }

    static int NhapSoNguyen(string thongBao)
    {
        while (true)
        {
            Console.Write(thongBao);

            string input = Console.ReadLine();
            if (input.ToUpper() == "K") return -1; // Thoát nếu nhấn 'K'

            if (int.TryParse(input, out int n) && n >= 2)
            {
                return n; // Đầu vào hợp lệ
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên lớn hơn hoặc bằng 2.");
            }
        }
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false; 
        }
        return true; 
    }
}
