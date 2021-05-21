using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsExercise1
{
    class Program
    {
        //Write a program and continuously ask the user to enter different names, until the user presses (without supplying a name). 
        //Depending on the number of names provided, display a message based on the above pattern.
        static void Main(string[] args)
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a persons first name (or press enter to quit): ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0}, {1} like your post", names[0], names[1]);
            else
                Console.WriteLine();
        }
    }
}
