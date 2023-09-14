using System;

// Here we are defining the Weapon class that inherits from the Item class.
public class Weapon : Item
{
    // Private fields for storing properties
    private WeaponType sword;
    private int v;

    // Public properties for the Weapon class
    public WeaponType WeaponType { get; set; }  // The type of weapon (e.g., sword, axe)
    public int WeaponDamage { get; set; }        // The damage value of the weapon

    // Constructor for creating a Weapon object
    public Weapon(string name, int requiredLevel, WeaponType weaponType, int weaponDamage)
        : base(name, requiredLevel, Slot.Weapon)
    {
        // Initialize the properties of the Weapon
        WeaponType = weaponType;      // Set the weapon type
        WeaponDamage = weaponDamage;  // Set the weapon damage
    }

    // Additional constructor (appears to be unused and can be removed)
    public Weapon(string name, int requiredLeven, Slot slot, WeaponType sword, int v)
        : base(name, requiredLeven, slot)
    {
        this.sword = sword;
        this.v = v;
    }
}
