using VerboseExpression;
using System.Text.RegularExpressions;
using System;
using System.Linq;
using System.Threading;

namespace Tests
{
    class Test
    {
        static void Main(string[] args)
        {
            while(true)
            {
                VerboseRegex verboseRegex = new VerboseRegex(RegexOptions.IgnoreCase);
                verboseRegex.Matches("abc");

                string testCase = RandomString(5);
                if (verboseRegex.Finalize().IsMatch(testCase))
                {
                    Console.WriteLine("Case: "+testCase+" is a match to abc regex.");
                } else
                {
                    Console.WriteLine("Case: " + testCase + " is not a match.");
                }
                Thread.Sleep(800);
            }
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray()).ToLower();
        }
    }
}
