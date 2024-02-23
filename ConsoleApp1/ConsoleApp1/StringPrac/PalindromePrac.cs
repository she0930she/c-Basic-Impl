using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.StringPrac
{
    public class PalindromePrac
    {
        public string[] ConvertToStringArr(string words)
        {
            List<string> ans = new List<string>();
            string cur = "";
            foreach (char cha in words)
            {
                if (!Char.IsLetter(cha))
                {
                    if (cur.Length != 0) ans.Add(cur);
                    cur = "";
                    continue;
                }
                
                // IsLetter
                cur += cha;
            }
            if (cur.Length != 0) ans.Append(cur);
            //Console.WriteLine("ans.Count: "+ ans.Count);
            
            string[] res = new string[ans.Count];
            for (int i = 0; i < ans.Count; i++)
            {
                res[i] = ans[i];
            }

            return res;
        }

        public void printPalindromeOnly(string words)
        {
            string[] arr = ConvertToStringArr(words);
            
            List<string> ans = new List<string>(); 
            
            foreach (string word in arr)
            {
                if (IsPalindrome(word))
                {
                    ans.Add(word);
                }
            }
            ans.Sort();
            string pre = "";
            for (int i = 0; i < ans.Count; i++)
            {
                if (ans[i] == pre) continue;  // duplicated
                
                Console.Write($"{ans[i]}");
                
                if (i != ans.Count - 1) // not the last word
                {
                    Console.Write(", ");
                }

                pre = ans[i]; // update previous string
            }
            
            
        }

        public bool IsPalindrome(string word)
        {
            if (word == null || word.Length == 0) return false;

            int l = 0, r = word.Length - 1;
            while (l < r)
            {
                if (word[l] != word[r])
                {
                    return false;
                }
                l++;
                r--;
            }

            return true;
        }
    }
}