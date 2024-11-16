using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(DateTime.Now.Microsecond);
            Console.WriteLine("Enter the lower bound of the random number: ");
            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the upper bound of the random number: ");
            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());
            if (lowerMaxRandomBound > upperMaxRandomBound)
            {
                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
            }
            Console.WriteLine("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);

            }
            Console.WriteLine("The array is: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }


            Console.WriteLine();
            Console.WriteLine("Enter the parameter : ");
            int par = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i < size; i++)
            {
                if (arr[i] < par)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
