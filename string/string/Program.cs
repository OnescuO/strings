using System;

namespace myString
{
    class Program
{
    static void Main(string[] args)
    {
        string myString = "Hello World!";
        for (int i = 0;  i < myString.Length; i++)
        {
            Console.WriteLine(myString[i]);
        }

            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[i]);
            }

            string myCoolString = "My awesome string";
            Console.WriteLine(myCoolString.Length);

            string s = string.Empty;
            string b = s;
            Console.WriteLine(s);
            Console.WriteLine($"b : {b}");

            int myInt = 30;
            string myIntAsString = myInt.ToString();
            Console.WriteLine($"myIntAsString: {myIntAsString}");
        
    }
}
}
