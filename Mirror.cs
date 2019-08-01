using System;

namespace WhiteBoardAct
{
    class Mirror
    {

        public static string MirrorName(string firstName)
        {
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine();

            string result = MirrorName(firstName);

            Console.WriteLine("Results: " + result);

            Console.ReadLine();

            {

            }
        }

       
            

    }
}
