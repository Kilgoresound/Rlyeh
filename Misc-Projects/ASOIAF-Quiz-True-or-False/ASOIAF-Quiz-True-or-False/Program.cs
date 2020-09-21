using System;

namespace ASOIAF_Quiz_True_or_False
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Maester Yandel's Quiz\nReady to test your knowledge of Westerosi history? Press Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = { "1 Tyrion Lannister is also known as \"The Kingslayer\".", "2 The sigil of House Targaryen is a red three-headed dragon on a field of black.", "3 The surname given to highborn bastards from the Riverlands is \"Waters\".", "4 The Lannister's house words are \"A Lannister Always Pays His Debts\".", "5 Ser Garlan Tyrell wore Renly's armor at The Battle of the Blackwater.", "6 Ser Jorah Mormont was condemned to execution by Lord Eddard Stark.", "7 The first wife of Ramsay Snow was Lady Barbrey Dustin.", "8 The opening chapter of \"A Game of Thrones\" is told from the viewpoint of Ser Waymar Royce.", "9 The six familiars of the psychotic skinchanger known as Varamyr Sixskins are: a snow bear, three wolves, an eagle and a shadowcat.", "10 The Seven Kindoms of Westeros are: The North, The Vale, The Reach, The Riverlands, The Iron Islands, The Westerlands and The Stormlands.", "11 Torrhen Stark, The King Who Knelt, was not the only ruler of Westeros to surrender to Aegon I Targaryen during The Conquest." };

            bool[] answers = { false, true, false, false, true, true, false, false, true, false, true };

            bool[] responses = new bool[11];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("The number of questions and answers do not match!");
            }

            int askingIndex = 0;

            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine($"\n\n{questions[askingIndex]}");
                Console.WriteLine("TRUE or FALSE?");
                input = Console.ReadLine();
                isBool = Boolean.TryParse(input, out inputBool);
                responses[askingIndex] = inputBool;
                askingIndex++;

                while (isBool != true)
                {
                    Console.WriteLine("\n\nPardons, my child. I'm afraid I'll need a clear TRUE or FALSE to continue with my assessment. Once again?");
                    Console.WriteLine($"\n\n{questions[askingIndex - 1]}");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
            }

            Console.WriteLine($"\n\nWell done, my child. Shall we take a look at your scorecard?");
            Console.WriteLine("Press ENTER to see your score.");
            Console.Read();

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"\n\nQuestion {scoringIndex + 1}.\nYour Response: {response} | Answer: {answer}");
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;

            }

            switch (score)
            {
                case 1:
                    Console.WriteLine($"\n\nOh my, a score of {score}. An absolutely horrid show of skill indeed. You have much to learn about the history of Westeros yet.");
                    break;

                case 2:
                    Console.WriteLine($"\n\nA score of {score}. A very poor show. Quite awful, I'm afraid.");
                    break;

                case 3:
                    Console.WriteLine($"\n\nYour score for this round is {score}. Far below average. I trust you understand there is much work to do yet.");
                    break;

                case 4:
                    Console.WriteLine($"\n\nA score of {score} is below average, however I see you have been paying the minimum amount of attention due. There is much room for improvement.");
                    break;

                case 5:
                    Console.WriteLine($"\n\nYour score totals {score}. Quite unremarkable, though perhaps impressive to a flea bottom lad.");
                    break;

                case 6:
                    Console.WriteLine($"\n\nAh, you scored a {score}. Not an awful show by any measure, but plenty of opportunity to improve.");
                    break;

                case 7:
                    Console.WriteLine($"\n\nYou scored {score} this round. Only slightly above-average in every regard for a highborn.");
                    break;

                case 8:
                    Console.WriteLine($"\n\nYes, yes. Good show. You managed an {score}. Your knowledge is becoming impressive.");
                    break;

                case 9:
                    Console.WriteLine($"\n\nA good round indeed! You pulled off a {score}. You possess knowledge on a level with some of the finest highborn scholars.");
                    break;

                case 10:
                    Console.WriteLine($"\n\nWithout a doubt among the best scores I've seen yet. A magnificent {score}. The Crone herself might well be impressed with this show of knowledge.");
                    break;

                case 11:
                    Console.WriteLine($"\n\nA perfect score of {score}. I never thought I'd see the day. A wonderous achievment indeed. Your knowledge may well surpass many a Maester of the Citadel.");
                    break;

            }

            Console.Read();
        }
    }
}