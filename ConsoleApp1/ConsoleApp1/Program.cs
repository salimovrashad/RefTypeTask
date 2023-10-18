namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 8, -11, 16, -4, 7, -8, 9, 22 };
            Negative(arr);
        }
        static void Negative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] *= -1;
                }
                Console.WriteLine(arr[i]);
            }
        }
        
    }
}