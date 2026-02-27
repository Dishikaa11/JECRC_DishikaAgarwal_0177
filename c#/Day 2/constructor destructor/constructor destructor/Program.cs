//using System;
//class ODLExercise
//{
//    private static int number;
//    public static int Number
//    {
//        get { return number; }
//    }
//    static ODLExercise()
//    {
//        Random r = new Random();
//        number = r.Next();
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    { 
//        Console.WriteLine("static number =  " + ODLExercise.Number);
//    }
//}

//non static version of the above code

//using System;
//class ODLExercise
//{
//    private int number;
//    public int Number
//    {
//        get { return number; }
//    }
//    public ODLExercise()
//    {
//        Random r = new Random();
//        number = r.Next();
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        ODLExercise num = new ODLExercise();
//        Console.WriteLine("static number =  " + num.Number);
//        Console.ReadLine();
//    }
//}


//parameterized constructor

using System;
class ODLExercise
{
    private int number;
    public int Number
    {
        get { return number; }
    }
    public ODLExercise()
    {
        Random r = new Random();
        number = r.Next();
    }

    public ODLExercise(int seed)
    {
        Random r = new Random(seed);
        number = r.Next();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ODLExercise num = new ODLExercise();
        Console.WriteLine("static number =  " + num.Number);
        ODLExercise num1 = new ODLExercise(500);
        Console.WriteLine("static number with seed 500 =  " + num1.Number);
        Console.ReadLine();
    }
}