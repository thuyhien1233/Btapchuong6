using System;

public abstract class Shape
{
    private int soDinh;

    public int SoDinh
    {
        get { return soDinh; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("So dinh phai lon hon 0.");
            }
            soDinh = value;
        }
    }

    public Shape(int soDinh)
    {
        SoDinh = soDinh;
    }
}

public class TamGiac : Shape
{
    public TamGiac() : base(3) { }

    public void HienThiSoDinh()
    {
        Console.WriteLine($"Tam giac co so dinh: {SoDinh}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            TamGiac tg = new TamGiac();
            tg.HienThiSoDinh();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
