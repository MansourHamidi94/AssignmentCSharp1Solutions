using System;
public class Swashbuckler : Hero
{
    public Swashbuckler(string name) : base(name)
    {
        ValidWeaponTypes = new List<WeaponType> { WeaponType.Dagger, WeaponType.Sword };
        ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
        // Initialize Swashbuckler-specific properties and logic
        // ...
    }

    public override void LevelUp()
    {
        // Increase the level by 1 and adjust LevelAttributes when a Swashbuckler levels up.
        // For a Swashbuckler, every level up should increase Strength by 1 and Dexterity by 4.
        Level++;
        LevelAttributes.Increase(1, 4, 0);
    }

    public override int Damage()
    {
        // Calculate damage based on the equipped weapon (if any) and the Swashbuckler's attributes.
        // For a Swashbuckler, damage is increased by the total Dexterity.
        // If no weapon is equipped, take WeaponDamage as 1.
        int weaponDamage = Equipment[Slot.Weapon] != null ? ((Weapon)Equipment[Slot.Weapon]).WeaponDamage : 1;
        int damagingAttribute = TotalAttributes().Dexterity;
        // Calculate damage based on the formula provided in the assignment.
        int calculatedDamage = (int)(weaponDamage * (1 + damagingAttribute / 100.0));
        // Now you can use calculatedDamage for whatever purpose you need.
        return 0;
    }
}
