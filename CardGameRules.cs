namespace GWTextAdventure;

public class CardGameRules
{
    public static void InitCardGame(string cardGame, Hero champion)
    {
        if (cardGame == "highestcard")
        {
            Card championCard = new Card();
            Card opponentCard = new Card();
            HighestCard(championCard, opponentCard, champion);
        }
    }
    public static void HighestCard(Card firstCard, Card secondCard, Hero champion)
    {
        CardPlayer[] opponents =
        {
            CardPlayer.CreateCardPlayer("Leif Lockhart"), 
            CardPlayer.CreateCardPlayer("Gunnar Gunnarsson"),
            CardPlayer.CreateCardPlayer("Wilma Winters")
        };
        Console.Clear();
        int roll = Dice.RollD6();
        switch (roll)
        {
            case 1:
                case 2:
                    Program.Print($"Your opponent introduces themselves as {opponents[0].Name}");
                    break;
            case 3:
                case 4:
                    Program.Print($"Your opponent introduces themselves as {opponents[0].Name}");
                break;
            
            case 5:
                case 6:
                    Program.Print($"Your opponent introduces themselves as {opponents[0].Name}");
                    break;
        }
        Program.Print("Hej");
        
        if (firstCard.IntValue > secondCard.IntValue)
        {
            Program.Print($"{firstCard.Name}");
        }

        if (firstCard.IntValue == secondCard.IntValue)
        {
            if (firstCard.SuitValue > secondCard.SuitValue)
            {
                Program.Print($"{firstCard.Name}");
            }
        }

        Program.Print($"{secondCard.Name}");
    }

    public class CardPlayer
    {
        public string Name;
        public static Card Card = Card.CreateCard();

        public static CardPlayer CreateCardPlayer(string name)
        {
            CardPlayer npc = new CardPlayer();
            npc.Name = name;
            return npc;
        }
    }
}