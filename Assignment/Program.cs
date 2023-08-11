namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the elements of the array separated by spaces: ");
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.Write("Enter the value of k: ");
            int k = int.Parse(Console.ReadLine());

            Solution solution = new();
            IList<int> result = solution.MaxFrequency(nums, k);

            Console.WriteLine("Top k frequent elements:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}