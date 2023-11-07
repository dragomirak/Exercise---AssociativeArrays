namespace P01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charsOccurency = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (currentSymbol == ' ')
                {
                    continue;
                }

                if (!charsOccurency.ContainsKey(currentSymbol))
                {
                    charsOccurency[currentSymbol] = 0;
                }

                charsOccurency[currentSymbol]++;
            }

            foreach (KeyValuePair<char, int> kvp in charsOccurency)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}