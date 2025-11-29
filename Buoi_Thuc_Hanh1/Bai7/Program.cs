using TamGiacApp;

class Program
{
    static void Main(string[] args)
    {
        // Khởi tạo tam giác với các giá trị mặc định
        TamGiac tg1 = new TamGiac();
        Console.WriteLine("Tam Giac 1:");
        tg1.HienThi();

        // Khởi tạo tam giác với 3 tham số
        TamGiac tg2 = new TamGiac(5, 6, 7);
        Console.WriteLine("\nTam Giac 2:");
        tg2.HienThi();

        Console.ReadLine();
    }
}