namespace HashConverter
{
    internal static class Joaat
    {
        public static uint Compute(string key)
        {
            key = key.ToLower();
            uint hash = 0;

            foreach (char c in key)
            {
                hash = (hash + c) & 0xFFFFFFFF;
                hash = (hash + ((hash << 10) & 0xFFFFFFFF)) & 0xFFFFFFFF;
                hash = (hash ^ (hash >> 6)) & 0xFFFFFFFF;
            }

            hash = (hash + ((hash << 3) & 0xFFFFFFFF)) & 0xFFFFFFFF;
            hash = (hash ^ (hash >> 11)) & 0xFFFFFFFF;
            hash = (hash + ((hash << 15) & 0xFFFFFFFF)) & 0xFFFFFFFF;

            return hash;
        }

        public static string SignedCompute(string key)
        {
            return ((int)Compute(key)).ToString();
        }

        public static string UnsignedCompute(string key)
        {
            return Compute(key).ToString();
        }

        public static string HexCompute(string key)
        {
            return "0x" + Compute(key).ToString("X8");
        }
    }
}