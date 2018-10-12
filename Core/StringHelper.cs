using System;
using System.Collections.Generic;
using System.Text;

namespace CodingDojo.FooBarQix.Core
{
    public class StringHelper
    {
        private const string Foo = "Foo";
        private const string Bar = "Bar";
        private const string Qix = "Qix";

        private static readonly IDictionary<char, String> SubstitionMap = new Dictionary<char, String>()
        {
            { '3', Foo },
            { '5', Bar },
            { '7', Qix }
        };

        public static String Compute(String text)
        {
            Int32 input = Int32.Parse(text);

            StringBuilder strBuilder = new StringBuilder();

            AppendIfDivisibleBy(input, 3, strBuilder, Foo);
            AppendIfDivisibleBy(input, 5, strBuilder, Bar);
            AppendIfDivisibleBy(input, 7, strBuilder, Qix);

            ReplaceChars(text, strBuilder);

            if (strBuilder.Length == 0)
                strBuilder.Append(text);

            string result = strBuilder.ToString();
            return result;
        }

        private static void ReplaceChars(string text, StringBuilder strBuilder)
        {
            foreach (char c in text)
            {
                if (SubstitionMap.ContainsKey(c))
                {
                    string substitute = SubstitionMap[c];
                    strBuilder.Append(substitute);
                }
            }
        }

        /// <summary>
        /// Append <paramref name="value"/> to <paramref name="strBuilder"/> if <paramref name="input"/> is divisible by <paramref name="divisor"/>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="divisor"></param>
        /// <param name="strBuilder"></param>
        /// <param name="value"></param>
        private static void AppendIfDivisibleBy(int input, int divisor, StringBuilder strBuilder, string value)
        {
            if (input % divisor == 0)
                strBuilder.Append(value);
        }
    }
}
