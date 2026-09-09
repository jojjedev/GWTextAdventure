namespace GWTextAdventure;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Press Enter to start your new adventure!");
        Console.Read();
        Console.Clear();
        Hero champion = new Hero();
        while (champion.Location != "quit")
        {
            switch (champion.Location)
            {
                case "newgame":
                    Area.NewGame(champion);
                    continue;
                case "deadend":
                    Area.DeadEnd(champion);
                    continue;
            }
        }
    }
}