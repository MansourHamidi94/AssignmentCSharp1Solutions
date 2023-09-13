using System;
using System.Collections.Generic;

public abstract class Hero
{
    public string Name { get; set; }
    public int Level { get; set; }
    public HeroAttribute LevelAttributes { get; set; }
    public Dictionary<Slot, Item> Equipment { get; set; }
    public List<WeaponType> ValidWeaponTypes { get; set; }
    public List<ArmorType> ValidArmorTypes { get; set; }

    public Hero(string name)
    {
        Name = name;
        Level = 1;
        LevelAttributes = new HeroAttribute(0, 0, 0);
        Equipment = new Dictionary<Slot, Item>
        {
            { Slot.Weapon, null },
            { Slot.Head, null },
            { Slot.Body, null },
            { Slot.Legs, null }
        };
        ValidWeaponTypes = new List<WeaponType>();
        ValidArmorTypes = new List<ArmorType>();
    }

    public void Equip(Weapon weapon)
    {
        //public void Equip(Weapon weapon)
        {
            if (weapon == null)
            {
                throw new ArgumentNullException(nameof(weapon), "Weapon cannot be null.");
            }

            if (!ValidWeaponTypes.Contains(weapon.WeaponType))
            {
                throw new InvalidWeaponException($"Invalid weapon type for {this.GetType().Name}: {weapon.WeaponType}");
            }

            if (Level < weapon.RequiredLevel)
            {
                throw new InvalidWeaponException($"Level {Level} hero cannot equip a level {weapon.RequiredLevel} weapon.");
            }

            Equipment[Slot.Weapon] = weapon;
        }

    }

    public void Equip(Armor armor)
    {
        //public void Equip(Armor armor)
        {
            if (armor == null)
            {
                throw new ArgumentNullException(nameof(armor), "Armor cannot be null.");
            }

            if (!ValidArmorTypes.Contains(armor.ArmorType))
            {
                throw new InvalidArmorException($"Invalid armor type for {this.GetType().Name}: {armor.ArmorType}");
            }

            if (Level < armor.RequiredLevel)
            {
                throw new InvalidArmorException($"Level {Level} hero cannot equip a level {armor.RequiredLevel} armor.");
            }

            // Replace the old armor in the same slot with the new one
            Equipment[armor.Slot] = armor;
        }

    }

    public abstract void LevelUp(); // Abstract method, implemented in child classes

    public abstract int Damage(); // Abstract method, implemented in child classes

    public HeroAttribute TotalAttributes()
    {
        // Calculate and return total attributes based on leveling attributes and equipped armor.
        HeroAttribute totalAttributes = LevelAttributes;
        foreach (var item in Equipment.Values)
        {
            if (item is Armor armor)
            {
                totalAttributes = totalAttributes.Add(armor.ArmorAttribute);
            }
        }
        return totalAttributes;
    }

    public string Display()
    {
        // Create a string representation of the hero's state and return it.
        // Include Name, Class, Level, Total Strength, Total Dexterity, Total Intelligence, and Damage.
        HeroAttribute attributes = TotalAttributes();
        int damage = Damage(); // You might need to modify the Damage method to return an int.
        string heroState = $"Name: {Name}\nClass: {this.GetType().Name}\nLevel: {Level}\n";
        heroState += $"Total Strength: {attributes.Strength}\n";
        heroState += $"Total Dexterity: {attributes.Dexterity}\n";
        heroState += $"Total Intelligence: {attributes.Intelligence}\n";
        heroState += $"Damage: {damage}\n";
        return heroState;
    }
}
