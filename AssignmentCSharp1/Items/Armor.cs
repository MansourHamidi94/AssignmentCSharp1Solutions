using System;

// Definition of the Armor class, which inherits from the Item class.
public class Armor : Item
{
    // Private fields (seemingly unused)
    private ArmorType plate;
    private HeroAttribute heroAttribute;

    // Public properties for the Armor class
    public ArmorType ArmorType { get; set; }        // The type of armor (e.g., cloth, leather)
    public HeroAttribute ArmorAttribute { get; set; } // Attributes provided by the armor

    // Constructor for creating an Armor object
    public Armor(string name, int requiredLevel, ArmorType armorType, HeroAttribute armorAttribute)
        : base(name, requiredLevel, Slot.Body)
    {
        // Initialize the properties of the Armor
        ArmorType = armorType;        // Set the armor type
        ArmorAttribute = armorAttribute;  // Set the armor attribute
    }

    // Additional constructor (appears to be unused and can be removed)
    public Armor(string name, int requiredLeven, Slot slot, ArmorType plate, HeroAttribute heroAttribute)
        : base(name, requiredLeven, slot)
    {
        this.plate = plate;
        this.heroAttribute = heroAttribute;
    }
}
