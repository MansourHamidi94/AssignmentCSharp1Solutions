using System;
public class Wizard : Hero
{
    public Wizard(string name) : base(name)
    {
        ValidWeaponTypes = new List<WeaponType> { WeaponType.Staff, WeaponType.Wand };
        ValidArmorTypes = new List<ArmorType> { ArmorType.Cloth };
        // Initialize the ValidWeaponTypes and ValidArmorTypes as specified in the assignment.
    }

    public override void LevelUp()
    {
        // Increase the level by 1 and adjust LevelAttributes when a Wizard levels up.
        // For a Wizard, every level up should increase Strength by 1, Dexterity by 1, and Intelligence by 5.
        Level++;
        LevelAttributes.Increase(1, 1, 5);
    }

    public override int Damage()
    {
        // Calculate damage based on the equipped weapon (if any) and the Wizard's attributes.
        // For a Wizard, damage is increased by the total Intelligence.
        // If no weapon is equipped, take WeaponDamage as 1.
        int weaponDamage = Equipment[Slot.Weapon] != null ? ((Weapon)Equipment[Slot.Weapon]).WeaponDamage : 1;
        int damagingAttribute = TotalAttributes().Intelligence;
        // Calculate damage based on the formula provided in the assignment.
        int calculatedDamage = (int)(weaponDamage * (1 + damagingAttribute / 100.0));
        // Now you can use calculatedDamage for whatever purpose you need.
        return 0;
    }
}
