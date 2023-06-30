namespace MachEighChallenge
{
    public class Find_Pairs
    {
        public static void Main(string[] args)
        {
            //Read arguments from command line
            List<int> numbers = new List<int>(Array.ConvertAll(args[0].Split(','), int.Parse));
            int targetSum = int.Parse(args[1]);

            //Find the pairs that sum to the target value 
            Find_Numbers_Pairs(numbers, targetSum);
        }
        public static void Find_Numbers_Pairs(List<int> numbers, int targetSum)
        {
            if(numbers.Count < 2)
            {
                //Error Message
                Console.WriteLine("The list must contain at least two integers");
                return;
            }
            HashSet<int> complements = new HashSet<int>();
            bool pairFound = false;

            foreach (int num in numbers)
            {
                int complement = targetSum - num;
                if (complements.Contains(complement))
                {
                    Console.WriteLine($"+ {num},{complement}");
                    pairFound = true;
                }
                complements.Add(num);
            }
            if (pairFound == false)
            {
                Console.WriteLine("No pairs were found");
            }
        }
    }
}
