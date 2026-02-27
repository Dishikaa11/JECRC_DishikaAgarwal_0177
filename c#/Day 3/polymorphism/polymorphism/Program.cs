using System;


//polymorphism
//--------------Method overloading-----------------

//-------------------------------------------------

//class Car
//{
//    public string Name;
//    public int NumberOfDoors;
//    public Car()
//    {
//        Name = "NoName";
//        NumberOfDoors = 3;

//    }
//    public Car(string name, int numberOfDoors)
//    {
//        Name = name;
//        NumberOfDoors = numberOfDoors;
//    }
//    public Car(string name)
//    {
//        Name =name;
//        NumberOfDoors = 0;
//    }
//    public Car(int numberOfDoors)
//    {
//        Name = " ";
//       NumberOfDoors = numberOfDoors;
//    }
//    class ODLExce
//    {
//        static void Main(string[] args)
//        {
//            Car c1 = new Car();
//            Car c2 = new Car(3);
//            Car c3 = new Car("MyName");
//            Car c4 = new Car("yellooo", 4);
//            Console.WriteLine(c1.NumberOfDoors);
//            Console.WriteLine(c1.Name);
//            Console.WriteLine(c2.NumberOfDoors);
//            Console.WriteLine(c3.Name);
//            Console.WriteLine(c4.Name);
//            Console.WriteLine(c4.NumberOfDoors);

//        }
//    }
//}



// --------------method overriding-------------


//------------------------------------------------------before overriding----------------------------------------------------------




//class GroupAgent
//{
//    public void show()
//    {
//        Console.WriteLine("GroupAgent Created !!!!");
//        Console.ReadLine(); 

//    }
//}

//class Agent : GroupAgent
//{
//    public new void show()
//    {
//        Console.WriteLine("Agent Created !!!!");
//        Console.ReadLine();
//    }
//}

//class ODLExercise
//{
//    public static void Main()
//    {
//        GroupAgent a1 = new GroupAgent();
//        a1.show();
//        Agent b1 = new Agent();
//        b1.show();
//        GroupAgent a2 = new Agent();
//        a2.show();
//    }
//}

//--------------------------------------------------after overriding-----------------------------------------------------------

//class GroupAgent
//{
//    public virtual void show()
//    {
//        Console.WriteLine("GroupAgent Created !!!!");
//        Console.ReadLine();

//    }
//}

//class Agent : GroupAgent
//{
//    public override void show()
//    {
//        Console.WriteLine("Agent Created !!!!");
//        Console.ReadLine();
//    }
//}

//class ODLExercise
//{
//    public static void Main()
//    {
//        GroupAgent a1 = new GroupAgent();
//        a1.show();
//        Agent b1 = new Agent();
//        b1.show();
//        GroupAgent a2 = new Agent();
//        a2.show();
//    }
//}


//-------------sealed-----------------

class GroupAgent
{
    public virtual void show()
    {
        Console.WriteLine("GroupAgent Created !!!!");
        Console.ReadLine();

    }
}

class Agent : GroupAgent
{
    public sealed override void show()
    {
        Console.WriteLine("Agent Created !!!");
        Console.ReadLine();
    }
}

//class Booking : Agent
//{
//    public override void show()
//    {
//        Console.WriteLine("Booking Created !!!!");
//        Console.ReadLine();
//    }
//}

class ODLExercise
{
    public static void Main()
    {
        GroupAgent a1 = new GroupAgent();
        a1.show();
        Agent b1 = new Agent();
        b1.show();
        GroupAgent a2 = new Agent();
        a2.show();
    }
}