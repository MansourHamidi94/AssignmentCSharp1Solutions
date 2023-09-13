using System;
// Here we are defining the weapon class that inherits from "Item" class. 
public class Weapon : Item
{
    private WeaponType sword;
    private int v;

    public WeaponType WeaponType { get; set; }
    public int WeaponDamage { get; set; }

    public Weapon(string name, int requiredLevel, WeaponType weaponType,int weaponDamage)
        : base(name, requiredLevel, Slot.Weapon)
    {
        WeaponType = weaponType;
        WeaponDamage = weaponDamage;
    }

    public Weapon(string name, int requiredLeven, Slot slot, WeaponType sword, int v) : base(name, requiredLeven, slot)
    {
        this.sword = sword;
        this.v = v;
    }
}