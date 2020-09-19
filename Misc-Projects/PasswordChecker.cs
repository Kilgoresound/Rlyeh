using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            //password standard declarations
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = $"`~!@#$%^&*()-_=+<>,.?";

            int score = 0;

            //If you want an extra challenge, try adding these requirements: If the password is password or 1234, give it a score of 0.

            //Intro and capture user input
            Console.WriteLine("\n\n\n\nWelcome to Stealy's Password Checker!\nPress Enter to begin!");
            Console.ReadLine();

            Console.WriteLine("All right, here we go. Just type your password right here: ");
            string pw = Console.ReadLine();
            Console.WriteLine("All right, let's see what we got...\n\n\n\n");
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("All right, okay, now we're in the quiet safe room where we can see what we got.\n\n\n\n");
            System.Threading.Thread.Sleep(4000);

            int pwLength = pw.Length;

            if (pwLength >= minLength)
            {
                score++;
            }
            if (Tools.Contains(pw, uppercase))
            {
                score++;
            }
            if (Tools.Contains(pw, lowercase))
            {
                score++;
            }
            if (Tools.Contains(pw, digits))
            {
                score++;
            }
            if (Tools.Contains(pw, specialChars))
            {
                score++;
            }
            if (pw == "1234")
            {
                score = 0;
            }
            else if (pw == "password")
            {
                score = -1;
            }


            switch (score)
            {
                case 1:
                    Console.WriteLine($"No this just won't do. We only got about {score} brapple here.");
                    break;
                case 2:
                    Console.WriteLine($"Oh, that is no good. That one is only worth about {score} brapples.");
                    break;
                case 3:
                    Console.WriteLine($"Not so bad, we got about {score} and a half brapples here.");
                    break;
                case 4:
                    Console.WriteLine($"Oh good, good. We got about {score} brapples here.");
                    break;
                case 5:
                    Console.WriteLine($"Pristine! That one will get over {score} whole brapples!");
                    break;
                case -1:
                    Console.WriteLine($"SSSSHHHHHHHHHH....");
                    break;
                default:
                    Console.WriteLine("We got a bag of bobbish, but no plumbus. So no brapples!");
                    break;
            }

            Console.Read();
        }
    }
}
