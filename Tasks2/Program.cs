internal class Program
{
    private static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Console.ReadLine();

    }
    public static void Task1()
    {
        string a, b, t;
        b = (Console.ReadLine());
        a = (Console.ReadLine());
        t = (Console.ReadLine());
        Console.WriteLine(t + a + b);
    }
    public static void Task2()
    {
        int x, y;
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        if (x == y)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
    public static void Task3()
    {
        int num1, num2, num3, num4, sum;
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        num3 = Convert.ToInt32(Console.ReadLine());
        num4 = Convert.ToInt32(Console.ReadLine());
        sum = num1 + num2 + num3 + num4;
        Console.WriteLine(sum);
        if (sum>num1 && sum>num2 && sum >num3 && sum >num4)
        {
            Console.WriteLine( true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
    public static void Task4()
    {
        int x, y,z,t;
        x= Convert.ToInt32(Console.ReadLine());
        y= Convert.ToInt32(Console.ReadLine());
        z = Convert.ToInt32(Console.ReadLine());
        t = Convert.ToInt32(Console.ReadLine());

        if (x == y && x==z && x==t)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

    }

    public static void Task5()
    {
        long x, y;
        x = Convert.ToInt64(Console.ReadLine());
        y = Convert.ToInt64(Console.ReadLine());
        string z = (x / y).ToString();
        Console.WriteLine( z);
    }

    public static void Task6()
    {
        string x, y;
        x = (Console.ReadLine());
        y = (Console.ReadLine());
        Console.WriteLine(x+""+y);
    }
    public static void Task7()
    {
        string s;
        int x,y;
        s = (Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        x = int.Parse(s);
        Console.WriteLine(x + y);
    }
    public static void Task8()
    {
        int x,sum;
        sum = 0;
        x = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <=x; i++)
        {
           sum+= i;
        }
        Console.WriteLine(sum);
    }
    public static void Task9()
    {
        int x;
        x = Convert.ToInt32(Console.ReadLine());
        var result = x%2==0 ? true : false;
        Console.WriteLine(result);
    }
}