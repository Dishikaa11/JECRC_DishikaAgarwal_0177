using System;

// namespace ConsoleApp
// {
//     class Employee
//     {
//         public string Name{get; set;}
//         public int Id{get; set;}
//         public string Department{ get; set; }
//         public double salary { get; set; }
//         public string position{ get; set; }
//         public DateOnly Dateofjoining{ get; set; }
//         public void GetEmployeeData()
//         {
//             Console.WriteLine("Enter Employee Name: ");
//             Name = Console.ReadLine();
//             Console.WriteLine("Enter Employee Id: ");
//             Id = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter Department");
//             Department = Console.ReadLine();
//             Console.WriteLine("Enter Salary: ");
//             salary = Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter Employee position: ");
//             position = Console.ReadLine();
//             Console.WriteLine("Enter Employee joining date: ");
//             Dateofjoining = DateOnly.Parse(Console.ReadLine());
//         }
//         public void DisplayEmployeeData()
//         {
//             Console.WriteLine($"Employee Name: {Name} ");
//             Console.WriteLine($"Employee Id: {Id} ");
//             Console.WriteLine($"Employee department: {Department} ");
//             Console.WriteLine($"Employee salary: {salary} ");
//             Console.WriteLine($"Employee position: {position} ");
//             Console.WriteLine($"Employee date of joining: {Dateofjoining} ");
//         }

        
//     }
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee emp = new Employee();
//             emp.GetEmployeeData();
//             emp.DisplayEmployeeData();
//         }
//     }
    
// }


// using System;
// class ODLExample1
// {
//     public static void Main()
//     {
//         string[] stringArray = new string[3] { "Csharp", "Asp.Net", "Entity"};
//         Array.Sort(stringArray);
//         foreach(string str in stringArray)
//         {
//             Console.Write(str + " ");
//         }
//     }
// }

// using System;
// class Sameif
// {
//     public static void Main()
//     {
//         int a = 12;
//         int b = 10;

//         if(a > b)
//         {
//             Console.WriteLine("a is greatwr");
//         }
//         else
//         {
//             Console.WriteLine("b is graeter");
//         }
//     }
// }

//  using System;
// class SwitchSelect
// {
//     public static void Main()
//     {
//         string myInput;
//         int myInt;
//         begin:
//         Console.WriteLine("enter no. btw 1 and 3: ");
//         myInput = Console.ReadLine();
//         myInt = Int32.Parse(myInput);
//         switch(myInt)
//         {
//             case 1:
//                 Console.WriteLine("ypur no. is {0}.", myInt);
//                 break;
//             case 2:
//                 Console.WriteLine("ypur no. is {0}.", myInt);
//                 break;
//             case 3:
//                 Console.WriteLine("ypur no. is {0}.", myInt);
//                 break; 
//             default:
//                 Console.WriteLine("ypur no. is {0} is not btw 1 and 3", myInt);
//                 break;
//         }
//     }
// }

// class  sampledowhile
// {
//     public static void Main()
//     {
//         int a = 4;
//         do
//         {
//             Console.WriteLine(a);
//         }while(a<3);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter 3 letters:");
//         string input = Console.ReadLine();

//         if (input.Length == 3)
//         {
//             char[] arr = input.ToCharArray();
//             Array.Reverse(arr);
//             string reversed = new string(arr);

//             Console.WriteLine("Reversed letters: " + reversed);
//         }
//         else
//         {
//             Console.WriteLine("Please enter exactly 3 letters.");
//         }
//     }
// }





class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter width:");
        int width = Convert.ToInt32(Console.ReadLine());

        for (int i = width; i >= 1; i--)
        {N
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
    }
}
