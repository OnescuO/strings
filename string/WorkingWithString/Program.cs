using System;
using System.Diagnostics;
using System.Text;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = " Ana are mere! ";
            Console.WriteLine($"Index of a:{myString.IndexOf('a')}");
            Console.WriteLine($"Index of e:{myString.LastIndexOf('e')}");

            string mere = myString.Substring(9, 4);
            string mere2 = myString.Substring(myString.IndexOf('m'), 4);

            Console.WriteLine(mere2);
            string cleanString = myString.Trim();
            Console.WriteLine(cleanString);


            string cleanStringStart = myString.TrimStart();
            Console.WriteLine(cleanStringStart);

            string replacedString = myString.Replace(" ", ".");
            Console.WriteLine(replacedString);

            string replaceA = myString.Replace("a", "!", true, new System.Globalization.CultureInfo("en-us"));
            Console.WriteLine(replaceA);

            //split
            var splitted = myString.Trim().Split(new char[] {' '});

            for (int i = 0; i < splitted.Length; i++)
            {
                Console.WriteLine(splitted[i]);
            }

            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());

            Console.WriteLine(myString.Remove(9, 4));

            //concatenare
            string concatenated = "";
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 100; i++)
            {
                concatenated = concatenated + i.ToString();
            }
            timer.Stop();
           // Console.WriteLine(concatenated);
            Console.WriteLine(timer.Elapsed);

            //string builder
            StringBuilder stringBuilder = new StringBuilder();
            Stopwatch timerForBuilder = new Stopwatch();
            timerForBuilder.Start();
            for (int i = 0; i < 100; i++)
            {
                stringBuilder.Append(i.ToString());
            }
            timerForBuilder.Stop();
           // Console.WriteLine(stringBuilder);
            Console.WriteLine(timerForBuilder.Elapsed);

            double d = 0.375;
            var s = String.Format("{0,10:F5}", d);
            Console.WriteLine(s);

        }
    }
}
