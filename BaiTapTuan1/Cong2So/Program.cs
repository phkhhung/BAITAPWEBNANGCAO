using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Chương trình tính toán cơ bản. Nhấn 'K' để thoát bất cứ lúc nào.\n");

        while (true)
        {
            double soThuNhat = NhapSo("Nhập số thứ nhất: ");
            if (soThuNhat == double.MinValue) break; 

            double soThuHai = NhapSo("Nhập số thứ hai: ");
            if (soThuHai == double.MinValue) break; 

            char phepToan = NhapPhepToan();
            if (phepToan == 'K') break; 

            double ketQua;
            bool hopLe = TinhToan(soThuNhat, soThuHai, phepToan, out ketQua);

            if (hopLe)
            {
                Console.WriteLine($"\nKết quả của {soThuNhat} {phepToan} {soThuHai} là: {ketQua}\n");
            }
            else
            {
                Console.WriteLine("\nLỗi: Phép toán không hợp lệ (chia cho 0).\n");
            }
        }

        Console.WriteLine("Chương trình đã kết thúc.");
    }

    static double NhapSo(string thongBao)
    {
        while (true)
        {
            Console.Write(thongBao);

            string input = Console.ReadLine();
            if (input.ToUpper() == "K") return double.MinValue; 

            if (double.TryParse(input, out double ketQua))
            {
                return ketQua; 
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
            }
        }
    }

    static char NhapPhepToan()
    {
        while (true)
        {
            Console.Write("Nhập phép toán (+, -, *, /): ");
            string input = Console.ReadLine();
            if (input.ToUpper() == "K") return 'K'; 

            if (input.Length == 1 && "+-*/".Contains(input))
            {
                return input[0]; 
            }
            else
            {
                Console.WriteLine("Phép toán không hợp lệ. Vui lòng nhập lại.");
            }
        }
    }

    static bool TinhToan(double soThuNhat, double soThuHai, char phepToan, out double ketQua)
    {
        ketQua = 0;
        switch (phepToan)
        {
            case '+':
                ketQua = soThuNhat + soThuHai;
                return true;
            case '-':
                ketQua = soThuNhat - soThuHai;
                return true;
            case '*':
                ketQua = soThuNhat * soThuHai;
                return true;
            case '/':
                if (soThuHai == 0) return false;
                ketQua = soThuNhat / soThuHai;
                return true;
            default:
                return false; 
        }
    }
}
