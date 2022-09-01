using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

namespace PracticeExcercise0
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("mom "));
            Console.WriteLine(IsPalindrome("Mom"));
            Console.WriteLine(IsPalindrome("Race car"));
            Console.WriteLine(IsPalindrome("A nut for a jar of tuna"));

            Console.WriteLine(Reverse("coffee"));
            Console.WriteLine(Reverse("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(Reverse("Dad"));
            Console.WriteLine(Reverse(""));
            Console.WriteLine(Reverse("savannaH"));

            Console.WriteLine(ReverseInt(369)); // 963
            Console.WriteLine(ReverseInt(-396)); // -693 

            Console.WriteLine(IsUnique("mom"));
            IsUnique("");
            IsUnique("mom");
            IsUnique("Robbie");
            IsUnique("Judah");

        }


        // #1
        public static bool IsPalindrome(string s)
        {
            // clean up the string
            // remove spaces
            // lowercase it
            string cleanString = s.ToLower();
            cleanString = cleanString.Replace(" ", "");
            Console.WriteLine(cleanString);
            // reverse the clean string
            string reversed = Reverse(cleanString);
            // check if reverse is palindrome
            if( reversed == cleanString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string Reverse(string s)
        {
            string result = "";
            
            foreach( char c in s)
            {
               result = result.Insert(0, c.ToString());
            }

            return result;
        }

        // #2 
        public static int ReverseInt(int i)
        {
            //369 % 10 = 9
            //369/10 = 36
            // 36 % 10 = 6
            //36 / 10 = 3
            // 3 % 10 = 3
            // 3 / 10 = 0
            int x = i;
            int reverse = 0;
            


            while (x != 0)
            {
                int rem = x % 10;
                reverse = reverse * 10 + rem;
                x = x / 10;
            }


            return reverse;
        }

        // #3
        public static bool IsUnique(string s)
        {
            string cleanString = s.ToLower().Replace(" ", "");
            for( int i=0; i< cleanString.Length; i++)
            {
                // compare i to every subsequent letter

                for( int j=0; j< cleanString.Length; j++)
                {
                    if (cleanString[i] == cleanString[j])
                    {
                        return false;

                    }
                }

            }
            return true;
        }


        // #4
        public static bool IsNeilNumber(int i)
        {
            return true;
        }

    }
}
