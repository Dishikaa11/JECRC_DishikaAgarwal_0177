//using System;

//class Program
//{
//    static void Main(String[] args)
//    {
//        DateTime? dt = null;
//        dt = DateTime.Now;
//        object o = dt;
//        DateTime? dt2 = o as DateTime?;
//        if (dt2 != null) {
//            Console.WriteLine(dt2.Value.ToString());
//        }
//        Console.ReadLine();
//    }
//}

//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter a number:");
//        int num = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter width:");
//        int width = Convert.ToInt32(Console.ReadLine());

//        for (int i = width; i >= 1; i--)
//        {
//            for (int j = 1; j <= i; j++)
//            {
//                Console.Write(num);
//            }
//            Console.WriteLine();
//        }
//        Console.ReadLine();
//    }
//}


using System;
class Program
{
    static bool CheckEvenOdd(int a, int b)
    {
        if ((a % 2 == 0 && b % 2 == 0) ||
            (a % 2 != 0 && b % 2 != 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        bool result = CheckEvenOdd(num1, num2);

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
