namespace GWTextAdventure;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Print("Press Enter to start your new adventure!");
        Console.ReadLine();
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

    public static void Print(string text)
    {
        int dt = 400 / 60;
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(dt);
            
            
        }
        Console.WriteLine("\n");
    }
}