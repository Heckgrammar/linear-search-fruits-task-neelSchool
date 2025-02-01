namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // There is no readme file so my evidence will be here.
            // My code is going to run in O(n) time.
            // Because that is the maximum efficiency of linear search.
            // I am not using an IDE, I am just coding on github itself.
            Console.WriteLine("Enter fruit to find");
            string FruitToFind = (Console.ReadLine()).ToLower();
            bool found = false;
            foreach (string s in fruits)
            {
                if (s == FruitToFind)
                {
                    found = true;
                }
            }
            if (found == true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
