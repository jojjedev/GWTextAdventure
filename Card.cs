namespace GWTextAdventure;

public class Card
{
    public static string Suit;
    public static string Value;
    public string Name = $"{Value} of {Suit}";
    public int SuitValue;
    public int IntValue;
    private void CardValues(Card card)
    {
        switch (Suit)
        {
            case "hearts":
                SuitValue = 4;
                break;
            case "spades":
                SuitValue = 3;
                break;
            case "diamonds":
                SuitValue = 2;
                break;
            case "clubs":
                SuitValue = 1;
                break;
        }

        switch (Value)
        {
            case "ace":
                IntValue = 14;
                break;
            case "king":
                IntValue = 13;
                break;
            case "queen":
                IntValue = 12;
                break;
            case "jack":
                IntValue = 11;
                break;
            default:
                IntValue = int.Parse(Value);
                break;
        }
    }

    public Card CreateCard()
    {
        Card newCard = new Card();
        newCard.CardValues(newCard);
        return newCard;
    }
}