namespace GWTextAdventure;

public class CardGameRules
{
    public static void InitCardGame(string cardGame, Hero champion)
    {
        List<Card> deck = Card.CreateDeck();
        if (cardGame == "highestcard")
        {
            Card championCard = Card.RandomCard(deck);
            deck.Remove(championCard);
            Card opponentCard = Card.RandomCard(deck);
            deck.Remove(opponentCard);
            HighestCard(championCard, opponentCard, champion, deck);
        }
    }
    public static void HighestCard(Card firstCard, Card secondCard, Hero champion, List<Card> deck)
    {
        List<Card> Deck = deck;
        string opponentName = "";
        CardPlayer[] opponents =
        {
            CardPlayer.CreateCardPlayer("Leif Lockhart"), 
            CardPlayer.CreateCardPlayer("Gunnar Gunnarsson"),
            CardPlayer.CreateCardPlayer("Wilma Winters")
        };
        Console.Clear();
        int roll = Dice.RollD6();
        
        switch (roll) // Opponent introduction
        {
            case 1:
                case 2:
                    Program.Print($"Your opponent introduces themselves as {opponents[0].Name}");
                    opponentName = opponents[0].Name;
                    break;
            case 3:
                case 4:
                    Program.Print($"Your opponent introduces themselves as {opponents[1].Name}");
                    opponentName = opponents[1].Name;
                break;
            
            case 5:
                case 6:
                    Program.Print($"Your opponent introduces themselves as {opponents[2].Name}");
                    opponentName = opponents[2].Name;
                    break;
        }
        Program.Print($"...Cards get handed out to you and {opponentName}");
        Program.Print($"You have the {firstCard.Name}.");
        Question.Ask($"How much do you want to bet?\nYou currently have {champion.Wealth} coins.");
        //TODO: Fixa färdigt hur mycket man bettar och avgöra om man kan/vill köra fler rundor.
        Console.WriteLine(firstCard.Name + " | " + secondCard.Name);
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