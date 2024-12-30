using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Chào mừng đến với trò chơi đoán số!\n");

        Random rand = new Random();
        int soTrungThuong = rand.Next(1, 101);

        int soLanDoan = 0;
        int maxSoLanDoan = 7;

        Console.WriteLine("Hệ thống đã tạo ngẫu nhiên một số từ 1 đến 100.");
        Console.WriteLine($"Bạn có {maxSoLanDoan} lần đoán. Chúc bạn may mắn!\n");

        while (soLanDoan < maxSoLanDoan)
        {
            Console.Write($"Lần đoán thứ {soLanDoan + 1}: Nhập số bạn đoán (1-100): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int soDoan) || soDoan < 1 || soDoan > 100)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ từ 1 đến 100.\n");
                continue;
            }

            soLanDoan++; 

            if (soDoan == soTrungThuong)
            {
                Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng số {soTrungThuong} trong {soLanDoan} lần đoán!\n");
                return;
            }
            else if (soDoan < soTrungThuong)
            {
                Console.WriteLine("Số bạn đoán nhỏ hơn số trúng thưởng.\n");
            }
            else
            {
                Console.WriteLine("Số bạn đoán lớn hơn số trúng thưởng.\n");
            }
        }

        Console.WriteLine($"Rất tiếc! Bạn đã hết {maxSoLanDoan} lượt đoán. Số trúng thưởng là: {soTrungThuong}.");
        Console.WriteLine("Cảm ơn bạn đã chơi trò chơi!");
    }
}
