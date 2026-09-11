namespace GWTextAdventure;

public class Hero
{
    //public string Race = Question.AskRace();
    public string Name = Question.AskName();
    public string Profession = Question.AskProfession();
    public int Health;
    public int Defense;
    public int BaseDmg;
    public int Wealth = 50;
    public string Location = "newgame";
    

}