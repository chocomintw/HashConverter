namespace HashConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: HashConverter <string_to_hash>");
                return;
            }

            else
            {
                string input = args[0];
                uint hashValue = Joaat.Compute(input);
                string hashHex = Joaat.ComputeHex(input);
                Console.WriteLine($"Input String: {input}");
                Console.WriteLine($"Joaat Hash (Decimal): {hashValue}");
                Console.WriteLine($"Joaat Hash (Hex): {hashHex}");
            }
        }
    }
}