namespace GWTextAdventure;

public class Hero
{
    public string Race = Question.AskRace();
    public string Profession = Question.AskProfession();
    public string Name = Question.AskName();
    public int Health;
    public int Defense;
    public int BaseDmg;
    public string Location = "newgame";

}