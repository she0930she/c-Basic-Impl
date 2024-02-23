using System;
using System.Text;

namespace ConsoleApp1.StringPrac
{
    public class ReverseString
    {
        // for loop
        public void PrintReversedString(string word)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(word);
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(sb[i]);
            }
        }

        public string ToCharArrayStringReverse(string words)
        {
            string ans = "";
            char[] wordsArr = words.ToCharArray();

            int l = 0;
            int r = wordsArr.Length - 1;

            while (l < r)
            {
                char tmp = wordsArr[l];
                wordsArr[l] = wordsArr[r];
                wordsArr[r] = tmp;
                l++;
                r--;
            }
            
            
            return new string(wordsArr);
        }
    }
}