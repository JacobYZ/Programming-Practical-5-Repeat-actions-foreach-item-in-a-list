using System;
using System.Collections;
using System.Collections.Generic;

namespace foreach1
{
    class Program
{
    static void Main(string[] args)
    {
            List<string> animals = new List<string> { "elephant", "cat", "mouse", "snake", "giraffe" };
            //Note that collections like Lists have Count instead of an array's Length property
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine(animals[i]);
            }
            foreach (string s in animals)
            {
                Console.WriteLine(s);
            }
        }
}
}
