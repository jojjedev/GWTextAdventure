namespace GWTextAdventure;

public class CardGameRules
{
    public string HighestCard(Card firstCard, Card secondCard)
    {
        CardPlayer[] opponents =
        {
            CardPlayer.CreateCardPlayer("Leif"), 
            CardPlayer.CreateCardPlayer("Gunnar"),
            CardPlayer.CreateCardPlayer("Wilma")
        };
        
        if (firstCard.IntValue > secondCard.IntValue)
        {
            return firstCard.Name;
        }

        if (firstCard.IntValue == secondCard.IntValue)
        {
            if (firstCard.SuitValue > secondCard.SuitValue)
            {
                return firstCard.Name;
            }
        }

        return secondCard.Name;
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