namespace GWTextAdventure;

public class Area
{
    public static void NewGame(Hero champion)
        {
            Console.Clear();
            switch (champion.Race)
            {
                case "human":
                    champion.Location = "deadend";
                    break;
                case "charr":
                    champion.Location = "serratedblade";
                    break;
                case "norn":
                    champion.Location = "travelersloft";
                    break;
                case "asura":
                    champion.Location = "dynamics";
                    break;
                case "sylvari":
                    champion.Location = "starbower";
                    break;
                    
            } // Sätter starting zone beroende på race
    
            switch (champion.Profession)
            {
                case "elementalist":
                    champion.Health = 70;
                    champion.Defense = 10;
                    champion.BaseDmg = 30;
                    break;
                case "warrior":
                    champion.Health = 100;
                    champion.Defense = 20;
                    champion.BaseDmg = 15;
                    break;
                case "engineer":
                    champion.Health = 85;
                    champion.Defense = 15;
                    champion.BaseDmg = 20;
                    break;
            } // Sätter stats beroende på profession
            
            
        }

    public static void DeadEnd(Hero champion)
    {
        Console.WriteLine("You wake up in a soft bed in a guest room at the Dead End, a local tavern you drank yourself to sleep at last night.\n" +
                          "You walk downstairs to have some breakfast and while downstairs, you notice a game of poker being played.\n");
        bool response = Question.AskToConfirm("Do you want to join the game of cards?");
        if (response)
        {
            Console.Clear();
            Console.WriteLine("The game is simple. Every player gets dealt one card. The one with the highest wins!\n" +
                              "You gamble head to head and bet however much you want. Winner takes all!\n");
            Console.ReadLine();
            
        }
    }
}