using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSVirtualAcademyClassesCont
{
    class Program
    {
        private static string k = ""; //this makes a string that will update within the next method
                                    //really, from anywhere within this class
        static void Main(string[] args)
        {
            string j = ""; //this makes a string that will update within the for loop
                            //because we can't access i outside of the block

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString(); //l will only show within these bracket
                                            //because not defined outside of them
                }
            }

            Console.WriteLine($"Outside of the for loop: {j}.");
            Console.WriteLine($"Outside of the for loop: {k}.");
            Console.WriteLine();

            HelperMethod();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine($"The value k from the HelperMethod = {k}.");
        }

        //this next part would work if they were in a class.
        //don't really work here, because you didn't make a class.

        private string HiddenMethod() //this really should be in a class..
            //it's an example of a private method
            //that will be used by a public method...
        {
            return ($"The value k from the HiddenMethod is {k}.");
        }

        public void PrintMe()  //and this is the public method 
            //it can be seen by the Main method (the private one cannot, if it's in a class)
            //but it uses the private HiddenMethod
        {
            Console.WriteLine(HiddenMethod());
        }
    }
}
