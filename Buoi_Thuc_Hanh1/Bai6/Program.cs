using EmployeeApp;
using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("Nhap so luong nhan vien: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("So luog khong hop le. Nhap lai: ");
        }

        // Thiết lập lương cơ bản (static)
        double basic;
        Console.Write("Nhap luong co ban ap dung chung: ");
        while (!double.TryParse(Console.ReadLine(), out basic) || basic < 0)
        {
            Console.Write("Luong co ban khong hop le. nhap lai: ");
        }
        Employee.SetBasicSalary(basic);

        // Khởi tạo mảng nhân viên
        Employee[] employees = new Employee[n];

        // Nhập thông tin từng nhân viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhap thong tin nhan vien thu{i + 1}:");
            employees[i] = new Employee();
            employees[i].Input();
        }

        // Hiển thị danh sách nhân viên
        Console.WriteLine("\n{0,-10}{1,-20}{2,-15}{3,-15}{4,-15}",
            "ID", "Ho Ten", "Nam Sinh", "Luong CB", "Thu Nhap");

        foreach (Employee emp in employees)
        {
            emp.Display();
        }

        Console.ReadLine();
    }
}
