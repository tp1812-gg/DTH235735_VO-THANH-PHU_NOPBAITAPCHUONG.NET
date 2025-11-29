using System;

namespace EmployeeApp
{
    class Employee
    {
        // Thuộc tính đối tượng
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;

        // Thuộc tính static (dùng chung cho mọi nhân viên)
        private static double basicSalary;

        // --- Các phương thức getter ---
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetYearOfBirth()
        {
            return yearOfBirth;
        }

        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }

        // --- Phương thức nhập thông tin nhân viên ---
        public void Input()
        {
            Console.Write("Nhập ID: ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("ID khong hop le. Nhap lai: ");
            }

            Console.Write("Nhap ho va ten: ");
            name = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            while (!int.TryParse(Console.ReadLine(), out yearOfBirth) || yearOfBirth < 1900 || yearOfBirth > DateTime.Now.Year)
            {
                Console.Write("Nam sinh khong hop le. Nhap lai: ");
            }

            Console.Write("Nhap bac luong: ");
            while (!double.TryParse(Console.ReadLine(), out salaryLevel) || salaryLevel < 0)
            {
                Console.Write("Bac luong khong hop le. Nhap lai:");
            }
        }

        // --- Phương thức hiển thị thông tin nhân viên ---
        public void Display()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-15}{4,-15}",
                id, name, yearOfBirth, basicSalary, GetIncome());
        }

        // --- Thiết lập bậc lương ---
        public void SetSalaryLevel(double level)
        {
            if (level >= 0)
                salaryLevel = level;
        }

        // --- Thiết lập lương cơ bản (static) ---
        public static void SetBasicSalary(double salary)
        {
            if (salary >= 0)
                basicSalary = salary;
        }

        // --- Lấy lương cơ bản hiện tại (optional) ---
        public static double GetBasicSalary()
        {
            return basicSalary;
        }
    }
}
