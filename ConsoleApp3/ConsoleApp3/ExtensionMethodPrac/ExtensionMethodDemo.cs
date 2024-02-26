namespace ConsoleApp3.ExtensionMethodPrac
{
    public static class ExtensionMethodDemo
    {
        public static bool EvenOrOddMethod(this int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }

        public static string HasValue(this string word)
        {
            if (word == null || word.Length == 0) return $"not valid string input: {word}";
            return $"valid input: {word}";
        }
    }
}