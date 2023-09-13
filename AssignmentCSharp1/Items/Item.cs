using System;
// Item abstract class, which will serve as parent for "weapon" and "armor". 
public abstract class Item
{
    public string Name { get; set; }
    public int RequiredLevel { get; set; }
    public Slot Slot { get; set; }

    public Item(string name, int requiredLeven, Slot slot)
    {
        Name = name;
        RequiredLevel = RequiredLevel;
        Slot = slot;
    }

}
// "enum" is here used, because it improves the programs readability, maintainability and reduces complexity. 
public enum Slot
{
    Weapon,
    Head,
    Body,
    Legs
}