using System;
using System.Text;

namespace Bai28_Chuong6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            class_demo ob = new class_demo();
            ob.Show();

            ushort n;
            Console.WriteLine("Nhập n:");
            n = ob.nhapsonguyen2bytekhongdau();
            Console.WriteLine("n = " + n.ToString());
        }
    }
}
