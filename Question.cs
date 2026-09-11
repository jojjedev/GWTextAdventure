using System.Reflection.Metadata.Ecma335;

namespace GWTextAdventure;

public static class Question
{
    public static string Ask(string question)
    {
        
        string response;
        /*
        Program.Print(question);
        do
        {
            response = Console.ReadLine().Trim().ToLower();
        } while (response == "");
        */
        do
        {
            Program.Print(question);    
            response = Console.ReadLine().Trim().ToLower();
        } while (response == "");
         // Alternativ lösning på dubbelfrågaproblemet. Två frågor skrivs ut men man clearar bort den första.
        return response;
    }

    public static bool AskToConfirm(string question)
    {
        string response;
        while (true)
        {
            response = Ask(question + "(Y/n)");
            switch (response)
            {
                case "yes":
                    case "y" :
                    case "":
                    return true;
                case "no":
                    case "n":
                    return false;
                default:
                    Console.Clear();
                    Program.Print("Invalid input, please answer the question with 'yes' or 'no'.\n");
                    break;
            }
        }
    }

    /*public static string AskRace()
    {
        while (true)
        {
            string race = Ask("What is your race Champion?\n" +
                              "1. HUMAN\n" +
                              "2. CHARR\n" +
                              "3. NORN\n" +
                              "4. ASURA\n" +
                              "5. SYLVARI");
            switch (race)
            {
                case "1":
                    case "human":
                        race = "human";
                        break;
                case "2":
                    case "charr":
                        race = "charr";
                        break;
                case "3":
                    case "norn":
                        race = "norn";
                        break;
                
                case "4":
                    case "asura":
                        race = "asura";
                        break;
                case "5":
                    case "sylvari":
                        race = "sylvari";
                        break;
                default:
                    Console.Clear();
                    Program.Print("Invalid input, please enter one of the races\n");
                    break;
            }

            if (race is "human" or "charr" or "norn" or "asura" or "sylvari")
            {
                Console.Clear();
                bool confirmation = AskToConfirm($"So, {race} it is? ");
                if (confirmation)
                {
                    Console.Clear();
                    return race;
                }
                Console.Clear();
            }
        }
        
        
    }
*/
    public static string AskProfession()
    {
        while (true)
        {
            string profession = Ask("What is your profession?\n" +
                                    "1. Elementalist\n" +
                                    "2. Warrior\n" +
                                    "3. Engineer");
            switch (profession)
            {
                case "1":
                    case "elementalist":
                        case "ele":
                            profession = "elementalist";
                            break;
                case "2":
                    case "warrior":
                        case "war":
                            profession = "warrior";
                            break;
                case "3":
                    case "engineer" :
                        case "engi":
                            profession = "engineer";
                            break;
                default:
                    Console.Clear();
                    Program.Print("Invalid input. Choose one of the three professions!\n");
                    break;
            }

            if (profession is "elementalist" or "warrior" or "engineer")
            {
                Console.Clear();
                bool confirmation = AskToConfirm($"So, {profession} it is? ");
                if (confirmation)
                {
                    Console.Clear();
                    return profession;
                }
                Console.Clear();
            }
        }
    }

    public static string AskName()
    {
        while (true)
        {
            string name = Ask("What is your name Champion?");
            if (name != "")
            {
                Console.Clear();
                bool confirmation = AskToConfirm($"So, {name} it is?");
                if (confirmation)
                {
                    Console.Clear();
                    return name;
                }
                Console.Clear();
            }
        }
    }
}