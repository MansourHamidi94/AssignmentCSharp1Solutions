using System;
public class Archer : Hero
{
    public Archer(string name) : base(name)
    {
        ValidWeaponTypes = new List<WeaponType> { WeaponType.Bow };
        ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
        // Initialize Archer-specific properties and logic
        // ...
    }

    public override void LevelUp()
    {
        // Increase the level by 1 and adjust LevelAttributes when an Archer levels up.
        // For an Archer, every level up should increase Dexterity by 5.
        Level++;
        LevelAttributes.Increase(0, 5, 0);
    }

    public override int Damage()
    {
        // Calculate damage based on the equipped weapon (if any) and the Archer's attributes.
        // For an Archer, damage is increased by the total Dexterity.
        // If no weapon is equipped, take WeaponDamage as 1.
        int weaponDamage = Equipment[Slot.Weapon] != null ? ((Weapon)Equipment[Slot.Weapon]).WeaponDamage : 1;
        int damagingAttribute = TotalAttributes().Dexterity;
        // Calculate damage based on the formula provided in the assignment.
        int calculatedDamage = (int)(weaponDamage * (1 + damagingAttribute / 100.0));
        // Now you can use calculatedDamage.
        return 0;

    }
}
