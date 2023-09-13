using System;
public class HeroAttribute
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }

    public HeroAttribute(int strength, int dexterity, int intelligence)
    {
        Strength = strength;
        Dexterity = dexterity;
        Intelligence = intelligence;
    }

    public HeroAttribute Add(HeroAttribute other)
    {
        return new HeroAttribute(
            Strength + other.Strength,
            Dexterity + other.Dexterity,
            Intelligence + other.Intelligence
        );
    }

    public void Increase(int strength, int dexterity, int intelligence)
    {
        Strength += strength;
        Dexterity += dexterity;
        Intelligence += intelligence;
    }
}
