namespace GWTextAdventure;

public class Card
{
    public string Suit;
    public string Value;
    public string Name;
    public int SuitValue;
    public int IntValue;
    private void CardValues(Card card)
    {
        switch (card.Suit)
        {
            case "Hearts":
                SuitValue = 4;
                break;
            case "Spades":
                SuitValue = 3;
                break;
            case "Diamonds":
                SuitValue = 2;
                break;
            case "Clubs":
                SuitValue = 1;
                break;
        }

        switch (card.Value)
        {
            case "Ace":
                IntValue = 14;
                break;
            case "King":
                IntValue = 13;
                break;
            case "Queen":
                IntValue = 12;
                break;
            case "Jack":
                IntValue = 11;
                break;
            default:
                IntValue = int.Parse(card.Value);
                break;
        }
    }

    public static Card CreateCard()
    {
        Card newCard = new Card();
        return newCard;
    }

    public static List<Card> CreateDeck()
    {
        List<Card> deck = new List<Card>();
        string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };
        string[] values = { "Ace", "King", "Queen", "Jack", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        for (int i = 0; i < suits.Length; i++)
        {
            int suitValue = 4 - i;
            
            for (int j = 0; j < values.Length; j++)
            {
                int IntValue = 14 - j;
                Card currentCard = CreateCard();
                currentCard.Suit = suits[i];
                currentCard.Value = values[j];
                currentCard.SuitValue = suitValue;
                currentCard.IntValue = IntValue;
                currentCard.Name = $"{currentCard.Value} of {currentCard.Suit}";
                deck.Add(currentCard);
            }
        }
        

        return deck;
    }

    public static Card RandomCard(List<Card> deck)
    {
        Random random = new Random();
        int cardNumber = random.Next(1, 53);
        return deck[cardNumber];
    }
}