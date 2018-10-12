using System;
using System.Text;

namespace CodingDojo.FooBarQix.Core
{
    public class StringHelper
    {
        private const string Foo = "Foo";
        private const string Bar = "Bar";
        private const string Qix = "Qix";

        public static String Compute(String text)
        {
            Int32 input = Int32.Parse(text);

            StringBuilder strBuilder = new StringBuilder();

            if (input % 3 == 0)
                strBuilder.Append(Foo);

            if (input % 5 == 0)
                strBuilder.Append(Bar);

            if (input % 7 == 0)
                strBuilder.Append(Qix);

            foreach (char c in text)
            {
                if (c == '3')
                    strBuilder.Append(Foo);

                if (c == '5')
                    strBuilder.Append(Bar);

                if (c == '7')
                    strBuilder.Append(Qix);
            }

            if (strBuilder.Length != 0)
            {
                string result = strBuilder.ToString();
                return result;
            }

            return text;
        }
    }
}
