using System;
public class Barbarian : Hero
{
    public Barbarian(string name) : base(name)
    {
        ValidWeaponTypes = new List<WeaponType> { WeaponType.Hatchet, WeaponType.Mace, WeaponType.Sword };
        ValidArmorTypes = new List<ArmorType> { ArmorType.Mail, ArmorType.Plate };
        // Initialize Barbarian-specific properties and logic
        // ...
    }

    public override void LevelUp()
    {
        // Increase the level by 1 and adjust LevelAttributes when a Barbarian levels up.
        // For a Barbarian, every level up should increase Strength by 3.
        Level++;
        LevelAttributes.Increase(3, 0, 0);
    }

    public override int Damage()
    {
        // Calculate damage based on the equipped weapon (if any) and the Barbarian's attributes.
        // For a Barbarian, damage is increased by the total Strength.
        // If no weapon is equipped, take WeaponDamage as 1.
        int weaponDamage = Equipment[Slot.Weapon] != null ? ((Weapon)Equipment[Slot.Weapon]).WeaponDamage : 1;
        int damagingAttribute = TotalAttributes().Strength;
        // Calculate damage based on the formula provided in the assignment.
        int calculatedDamage = (int)(weaponDamage * (1 + damagingAttribute / 100.0));
        // Now you can use calculatedDamage for whatever purpose you need.
        return 0;
    }
}
