using System;
using System.Text;

namespace Bai28_Chuong6
{
    public class class_demo
    {
        public void Show()
        {
            Console.WriteLine("Tôi là một lớp đơn giản!");
        }

        public ushort nhapsonguyen2bytekhongdau()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ushort n = 0;
            while (true)
            {
                try
                {
                    string sz;
                    sz = Console.ReadLine();
                    n = ushort.Parse(sz);
                    break;
                }
                catch
                {
                    Console.Beep();
                    // Console.WriteLine("...");
                }
            }
            return n;
        }
    }
}
