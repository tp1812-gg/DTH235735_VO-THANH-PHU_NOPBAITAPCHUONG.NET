using System;

namespace TamGiacApp
{
    class TamGiac
    {
        // Các thuộc tính
        private int canh1;
        private int canh2;
        private int canh3;
        private float chuvi;
        private float dientich;

        // Thuộc tính cho các cạnh
        public int Canh1
        {
            get { return canh1; }
            set { canh1 = value; }
        }

        public int Canh2
        {
            get { return canh2; }
            set { canh2 = value; }
        }

        public int Canh3
        {
            get { return canh3; }
            set { canh3 = value; }
        }

        // Thuộc tính cho chu vi
        public float ChuVi
        {
            get { return chuvi; }
            set { chuvi = value; }
        }

        // Thuộc tính cho diện tích
        public float DienTich
        {
            get { return dientich; }
            set { dientich = value; }
        }

        // Phương thức khởi tạo không tham số với các giá trị mặc định
        public TamGiac()
        {
            Canh1 = 2;
            Canh2 = 3;
            Canh3 = -5;
        }

        // Phương thức khởi tạo với 3 tham số
        public TamGiac(int a, int b, int c)
        {
            Canh1 = a;
            Canh2 = b;
            Canh3 = c;
        }

        // Phương thức tính chu vi
        public float TinhChuVi()
        {
            chuvi = Canh1 + Canh2 + Canh3;
            return chuvi;
        }

        // Phương thức tính diện tích
        public float TinhDienTich()
        {
            float p = TinhChuVi() / 2;  // Nửa chu vi
            dientich = (float)Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));  // Công thức Heron
            return dientich;
        }

        // Phương thức hiển thị thông tin tam giác
        public void HienThi()
        {
            Console.WriteLine($"Chiều dài 3 cạnh: Canh1 = {Canh1}, Canh2 = {Canh2}, Canh3 = {Canh3}");
            Console.WriteLine($"Chu vi: {TinhChuVi()}");
            Console.WriteLine($"Diện tích: {TinhDienTich()}");
        }
    }
}