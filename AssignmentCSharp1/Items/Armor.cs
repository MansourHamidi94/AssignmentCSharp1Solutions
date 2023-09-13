using System;
public class Armor : Item
{
    private ArmorType plate;
    private HeroAttribute heroAttribute;

    public ArmorType ArmorType { get; set; }
    public HeroAttribute ArmorAttribute { get; set; }

    public Armor(string name, int requiredLevel, ArmorType armorType, HeroAttribute armorAttribute)
        : base(name, requiredLevel, Slot.Body) // You can adjust Slot as per the assignment
    {
        ArmorType = armorType;
        ArmorAttribute = armorAttribute;
    }

    public Armor(string name, int requiredLeven, Slot slot, ArmorType plate, HeroAttribute heroAttribute) : base(name, requiredLeven, slot)
    {
        this.plate = plate;
        this.heroAttribute = heroAttribute;
    }
}
