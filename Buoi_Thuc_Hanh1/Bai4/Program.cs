using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen dk = new MangSoNguyen();
            int n;
            Console.Write("Nhập vào số phần tử mảng = ");
            n = dk.NhapSoDuong();
            int[] a = new int[n];
            dk.NhapMang(a);
            Console.WriteLine("Mảng vừa nhập ");
            dk.InMang(a);
            Console.WriteLine("\nSố lớn nhất trong mảng {0}", dk.TimSoLonNhat(a));
            Console.WriteLine("\nSố nhỏ nhất trong mảng {0}", dk.TimSoNhoNhat(a));
            Console.WriteLine("\nTổng các phần tử trong mảng {0}", dk.TinhTong(a));
            Console.WriteLine("\nMang sau khi sắp tăng dần ");
            dk.SapXepTangDan(a);
            dk.InMang(a);
            Console.ReadLine();
        }
    }
}