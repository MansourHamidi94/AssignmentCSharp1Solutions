using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class BarbarianTests
{
    [TestMethod]
    public void CalculateDamage_WithValidWeaponAndArmor_ReturnsCorrectDamage()
    {
        // Arrange
        Barbarian barbarian = new Barbarian("Broly"); // Create a Barbarian hero
        Weapon hatchet = new Weapon("Common Hatchet", 1, Slot.Weapon, WeaponType.Hatchet, 2);
        Armor plateArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));

        // Act
        barbarian.Equip(hatchet); // Equip the hatchet
        barbarian.Equip(plateArmor); // Equip the plate armor
        int damage = barbarian.Damage(); // Calculate damage

        // Assert
        // The damage formula is 2 * (1 + ((5+1) / 100))
        Assert.AreEqual(2 * (1 + ((5 + 1) / 100)), damage);
    }

    [TestMethod]
    public void LevelUp_IncreasesLevelByOne()
    {
        // Arrange
        Barbarian barbarian = new Barbarian("Broly"); // Create a Barbarian hero

        // Act
        barbarian.LevelUp(); // Level up the Barbarian

        // Assert
        Assert.AreEqual(2, barbarian.Level);
    }

    [TestMethod]
    public void LevelUp_IncreasesAttributesCorrectly()
    {
        // Arrange
        Barbarian barbarian = new Barbarian("Broly"); // Create a Barbarian hero

        // Act
        barbarian.LevelUp(); // Level up the Barbarian

        // Assert
        HeroAttribute expectedAttributes = new HeroAttribute(3, 1, 0); // Assuming Barbarians gain 2 Strength and 1 Dexterity when leveling up.
        Assert.AreEqual(expectedAttributes, barbarian.LevelAttributes);
    }
}
