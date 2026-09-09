namespace GWTextAdventure;

public class Dice
{
    public static int RollD4()
    {
        Random random = new Random();
        int roll = random.Next(1, 5);
        return roll;
    }

    public static int RollD6()
    {
        Random random = new Random();
        int roll = random.Next(1, 7);
        return roll;
    }
    public static int RollD10()
    {
        Random random = new Random();
        int roll = random.Next(1, 11);
        return roll;
    }
    public static int RollD20()
    {
        Random random = new Random();
        int roll = random.Next(1, 21);
        return roll;
    }

}