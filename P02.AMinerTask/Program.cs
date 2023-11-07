namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "stop")
            {
                int currentQuantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    resources[input] = 0;
                }

                resources[input] += currentQuantity;
            }

            foreach(KeyValuePair<string, int> kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}