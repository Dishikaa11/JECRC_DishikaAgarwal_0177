using system;
class Arraysort
{
    static void Main(string[] args)
    {
        int[] arr = {5, 3, 8, 9, 0, 7};
        Array.Sort(arr);
        foreach(int i in arr)
        Console.WriteLine(i + " ");
    }
}