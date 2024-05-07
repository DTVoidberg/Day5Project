namespace PalindromeChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool replay = true;
            while (replay)
            {
                Console.WriteLine("Please enter a word:");
                string? userReply = Console.ReadLine();
                int userTotal = userReply.Length;
                bool isPalindrome = true;

                for (int i = 0; i < userTotal / 2; i++)
                {
                    if (userReply[i] != userReply[userTotal - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                Console.WriteLine(isPalindrome ? "The string is a palindrome." : "No, it's not a palindrome.");

                Console.WriteLine("Would you like to try again?:\ny or n");
                string? userRetry = Console.ReadLine();
                if (userRetry == "n")
                {
                    replay = false;
                    Console.WriteLine("Thank you for trying my Palindrome Checker.");
                }
            }
        }
    }
}