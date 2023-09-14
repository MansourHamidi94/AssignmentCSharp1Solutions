using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ArcherTests
{
    [TestMethod]
    public void CreateArcher_WithNameAndAttributes_CreatesArcherWithCorrectAttributes()
    {
        // Arrange
        string archerName = "Legolas";
        int expectedLevel = 1;
        HeroAttribute expectedAttributes = new HeroAttribute(5, 10, 3);

        // Act
        Archer archer = new Archer(archerName);

        // Assert
        Assert.AreEqual(archerName, archer.Name);
        Assert.AreEqual(expectedLevel, archer.Level);
        Assert.AreEqual(expectedAttributes.Strength, archer.LevelAttributes.Strength);
        Assert.AreEqual(expectedAttributes.Dexterity, archer.LevelAttributes.Dexterity);
        Assert.AreEqual(expectedAttributes.Intelligence, archer.LevelAttributes.Intelligence);
    }

    [TestMethod]
    public void LevelUp_WhenCalled_IncreasesArcherLevelAndAttributes()
    {
        // Arrange
        Archer archer = new Archer("Robin");
        int initialLevel = archer.Level;
        HeroAttribute initialAttributes = archer.LevelAttributes;

        // Act
        archer.LevelUp();

        // Assert
        Assert.AreEqual(initialLevel + 1, archer.Level);
        Assert.IsTrue(archer.LevelAttributes.Strength > initialAttributes.Strength);
        Assert.IsTrue(archer.LevelAttributes.Dexterity > initialAttributes.Dexterity);
        Assert.IsTrue(archer.LevelAttributes.Intelligence > initialAttributes.Intelligence);
    }

    // Additional tests for Archer class methods and behaviors can be added here.
}
