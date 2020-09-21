using System;

namespace Choose_Your_Adventure_Westeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE WHISPERS */
            Console.Write("\n\n\n\n\nWelcome to Tales from the Citadel: The Whispers\nWith Maester Yandel\n\n\n\n\n");
            Console.Write("Please press enter to summon the Maester.");
            Console.ReadLine();
            System.Threading.Thread.Sleep(2000);

            // Start by asking for the user's name:
            Console.Write("\n\n\nGreetings, child. May the Seven bless you. \nI am Maester Yandel, the resident scribe and a historian of sorts. May I know your name?: \n");
            string name = Console.ReadLine();
            Console.WriteLine($"Ah, {name}. Well met. I'm most pleased to make your acquaintence, truly. \nWelcome to the Citadel of Oldtown.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Well, {name}, I take it you are here for a tale, yes?\n");
            Console.Read();
            Console.WriteLine($"Very good, {name}. Very good indeed.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"The tale I have for you this evening is one of fate. \nIt is a tale in which you will be the principal decider of the outcome for all souls involved.");
            Console.ReadLine();
            Console.WriteLine($"During our story there will be moments where I will ask you to make a decision about how to proceed. \nPlease take care to consider your choices carefully, {name}. \nEvery decision comes with consequences.");
            Console.WriteLine("All clear?");
            Console.ReadLine();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"Very well, then. \n\nOur tale begins with you, {name}. You are on the trail of a lost Northern maiden named Sansa Stark, and have been informed a man named Nimble Dick might harbor some clue to her wherabouts.");
            Console.ReadLine();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine($"You tracked Dick to Maidenpool, and that is where we find you. \nSitting in the damp cellar of a seedy little tavern called The Stinking Goose. \nNo sign marked the Stinking Goose. It took you most of an hour to find it, down a flight of wooden steps beneath a knacker’s barn. \nThe cellar was dim and the ceiling low, and you thumped your head on a beam as you entered.");
            System.Threading.Thread.Sleep(6000);
            Console.ReadLine();
            Console.WriteLine($"No geese were in evidence. A few stools were scattered about, and a bench had been shoved up against one earthen wall. The tables were old wine casks, grey and wormholed. \nThe promised stink pervaded everything. \nMostly it was wine and damp and mildew, your nose told you, but there was a little of the privy too, and something of the lichyard.");
            System.Threading.Thread.Sleep(6000);
            Console.ReadLine();
            Console.WriteLine($"The only drinkers you noticed were three Tyroshi seamen in a corner, growling at each other through green and purple beards. \nThey gave you a brief inspection, and one said something that made the others laugh.");
            System.Threading.Thread.Sleep(6000);
            Console.ReadLine();
            Console.WriteLine($"Now I must ask, dear {name}: Did you react with hostility to this percieved slight?");
            Console.WriteLine($"YES or NO?:\n");
            string choice1 = Console.ReadLine();
            string choice1CAPS = choice1.ToUpper();

            //Choice 1 - Tyroshi Seamen

            if (choice1CAPS == "YES")
            {
                Console.WriteLine($"Oh. Bit of a hot head, I see?");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"Well, {name}, something made you forget your preparation for coldness, for mockery, for hostility. You had supped upon such meat before, and it has clouded your judgement.");
                System.Threading.Thread.Sleep(7000);
                Console.WriteLine($"You were overcome with rage. You draw your steel and rise.");
                System.Threading.Thread.Sleep(4000);
                Console.WriteLine($"The Tyroshi seamen have gone silent and are staring in your direction as you begin to stalk toward them.");
                Console.WriteLine($"They stand in unison just as the proprietor raises her voice: \n“If you’re going to cut him, do it somewheres else. We don’t want no trouble with Lord Tarly.”");
                System.Threading.Thread.Sleep(6000);
                Console.WriteLine($"You suddenly realize that this outburst has cost you your anonymity, and your quarry has been lost.");
                Console.Read();
                Console.WriteLine($"And so our tale ends, dear {name}. You never even saw Nimble Dick and Sansa Stark's fate is left uncertain.");
                Console.WriteLine("\nFarewell, and may the Crone grant you wisdom.\n\n\n");
                Console.Read();
                Console.WriteLine($"\n\n\n\n\nTHE END");
                Console.Read();
            }
            else if (choice1CAPS == "NO")
            {
                Console.WriteLine($"Well done, {name}. Wise to keep an even head. You had a purpose, after all. A calling.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"You noticed the proprietor stood behind a plank that had been placed across two barrels. \nShe was a woman, round and pale and balding, with huge soft breasts swaying beneath a soiled smock. \nShe looked as though the gods had made her out of uncooked dough.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine($"You had another choice here, didn't you? You are in a tavern, after all. \nIt would be odd if you were not drinking. \nDid you order WINE or WATER?:\n");
                string choice2 = Console.ReadLine();
                string choice2CAPS = choice2.ToUpper();

                //Choice 2 - Water or Wine

                if (choice2CAPS == "WATER")
                {
                    Console.WriteLine($"Water, yes. You played it safe, {name}. You needed to keep your wits about you, yes?\nHaving too much wine could dull your senses and prove disasterous.");
                    Console.Read();
                    Console.WriteLine($"You bought your water, chugged it thirstily and said, “I am looking for a man called Nimble Dick.” \n\n“Dick Crabb. Comes in most every night.” The woman eyed your mail and sword. “If you’re going to cut him, do it somewheres else. We don’t want no trouble with Lord Tarly.”");
                    Console.WriteLine($"\n\n“I want to talk with him. Why would I do him harm?”");
                    Console.WriteLine($"\n\nThe woman shrugged.");
                    Console.Read();
                    Console.WriteLine("\n\n“If you would nod when he comes in I’d be thankful.” \n\n“How thankful?” \n\nYou put a copper star on the plank between the two of you and found a place in the shadows with a good view of the steps. \n\nAnd a white hot knife pierced your guts.");
                    Console.Read();
                    Console.WriteLine($"Dear {name}, it was the water, wasn't it? The water cost you everything.");
                    Console.Read();
                    Console.WriteLine($"Fortunately, you did make it outside in time to unload your gutfull of pale oatmeal and runny eggs upon which you broke your fast that morning into the street.");
                    Console.Read();
                    Console.WriteLine($"You did not, however, remove your armour and trousers in time to avoid filling them with warm nightsoil, or even make an attempt.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine($"You knew there was no time.");
                    Console.Read();
                    Console.WriteLine($"Alas, and so our tale ends, {name}. So the story goes, you spent the night emptying your guts and emptying your bowels and never even got a glimpse of Nimble Dick. And you never heard another whisper of Sansa Stark.");
                    Console.Read();
                    Console.WriteLine($"\n\n\n\nFarewell my dear {name}. May the Crone light your way.\n\n\n\nTHE END.");

                }
                else if (choice2CAPS == "WINE")
                {
                    Console.WriteLine($"Wine, yes. Clever choice, {name}. A lesser traveler might think they needed to avoid wine to keep their wits about them, yes?\nHaving too much wine could dull your senses and prove disasterous.");
                    Console.Read();
                    Console.WriteLine($"You knew better and did not dare to ask for water here.");
                    Console.Read();
                    Console.WriteLine($"You bought a cup of wine and said, “I am looking for a man called Nimble Dick.” \n\n“Dick Crabb. Comes in most every night.” The woman eyed your mail and sword. “If you’re going to cut him, do it somewheres else. We don’t want no trouble with Lord Tarly.”");
                    Console.WriteLine($"\n\n“I want to talk with him. Why would I do him harm?”");
                    Console.WriteLine($"\n\nThe woman shrugged.");
                    Console.Read();
                    Console.WriteLine("\n\n“If you would nod when he comes in I’d be thankful.” \n\n“How thankful?” \n\nYou put a copper star on the plank between the two of you and found a place in the shadows with a good view of the steps.");
                    Console.Read();
                    Console.WriteLine($"You tried the wine. It was oily on the tongue and there was a hair floating in it. \n\nA hair as slender as my hopes of finding Sansa, you thought as you plucked it out.");
                    Console.Read();
                }
            }

            Console.Read();
        }
    }
}
