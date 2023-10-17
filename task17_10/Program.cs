using task17_10.Models;

namespace task17_10
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ListInt array = new ListInt();
            array.Add(17);
            array.Add(15);
            array.Add(45);
            array.AddRange(3, 56, 12, 78, 87, 56);

            Console.WriteLine($"Ilkin arrayimiz:{array.ToString()}");

            Console.WriteLine($"Contains eledikden sonra:{array.Contains(5)}");

            array.Remove(15);
            Console.WriteLine($"Elementi sildikden sonra array :{array.ToString()}");

            array.RemoveRange(56, 78);
            Console.WriteLine($"Array delete eledikden sonra arrayimiz:{array.ToString()}");
        }

    }
}