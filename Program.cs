using System.Collections.Generic;

namespace HashConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: HashConverter <string_to_hash> [string2] [string3] ...");
                Console.WriteLine("Example: HashConverter \"hello world\" \"test\" \"another string\"");
                return;
            }

            for (int i = 0; i < args.Length; i++)
            {
                string input = args[i];
                string signedHash = Joaat.SignedCompute(input);
                string unsignedHash = Joaat.UnsignedCompute(input);
                string hexHash = Joaat.HexCompute(input);

                Console.WriteLine($"\n[{i + 1}/{args.Length}] Input: \"{input}\"");
                Console.WriteLine();
                Console.WriteLine($"Signed Decimal:   {signedHash}");
                Console.WriteLine($"Unsigned Decimal: {unsignedHash}");
                Console.WriteLine($"Hex:              {hexHash}");

                if (i < args.Length - 1)
                    Console.WriteLine();
            }
        }
    }
}

