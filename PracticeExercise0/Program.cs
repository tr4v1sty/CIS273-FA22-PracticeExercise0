using System;

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

            Console.WriteLine(ReverseInt(369));

            Console.WriteLine(IsUnique("mom"));
            IsUnique("");
            IsUnique("mom");
            IsUnique("Robbie");
            IsUnique("Judah");

        }


        // #1
        public static bool IsPalindrome(string s)
        {
            return true;
        }

        private static string Reverse(string s)
        {
            string result = "";
            

            return result;
        }

        // #2 
        public static int ReverseInt(int i)
        {
            return 0;
        }

        // #3
        public static bool IsUnique(string s)
        {
            
            return true;
        }


        // #4
        public static bool IsNeilNumber(int i)
        {
            return true;
        }

    }
}
