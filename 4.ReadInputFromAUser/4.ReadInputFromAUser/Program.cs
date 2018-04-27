using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Goals
 * Respond to user input
 * 
 * Below there is example code that demonstrates how to read in a line from a user, you may base your solution off of that.
 * Your responsibility is to ask someone for their name, and then print it back out to them.
 * 
 * 
 * New Commands:
 * if() statements
 * while() loops
 * Console.ReadLine();
 * 
 */
namespace _4.ReadInputFromAUser
{
    class Program
    {
        static void Main(string[] args)
        {
            ///While loops are formulated like this:
            /// while (boolean is true){
            /// //do something
            /// //do somthing else maybe
            /// }
            /// Now we're outside of the while loop
            /// 
            /// if() statments are the same way, but they'll only run once.

            //Instead of putting in a boolean variable, I put "true" so it will always loop. You can put variables in here too.
            //WARNING: This is an infinite loop, you would need to close the program manually unless you use a "break;"
            while (true)
            {
                Console.WriteLine("Would you like to break this loop? Type yes to continue");
                string userResponse = Console.ReadLine();//We can store the result of Console.Readline() into a string! This command also stops the code until someone enters code.

                if(userResponse == "yes")//Note this: == and = are different. == checks if two things are the same, and = makes them the same.
                {
                    break;
                }
                
            }

            //Ask someone for their name and then reprint it here
        }
    }
}
