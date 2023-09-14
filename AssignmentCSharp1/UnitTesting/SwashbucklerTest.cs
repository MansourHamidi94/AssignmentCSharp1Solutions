using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SwashbucklerTests
{
    [TestMethod]
    public void CreateSwashbuckler_WithNameAndAttributes_CreatesSwashbucklerWithCorrectAttributes()
    {
        // Arrange
        string swashbucklerName = "Krillin";
        int expectedLevel = 1;
        HeroAttribute expectedAttributes = new HeroAttribute(6, 8, 2);

        // Act
        Swashbuckler swashbuckler = new Swashbuckler(swashbucklerName);

        // Assert
        Assert.AreEqual(swashbucklerName, swashbuckler.Name);
        Assert.AreEqual(expectedLevel, swashbuckler.Level);
        Assert.AreEqual(expectedAttributes.Strength, swashbuckler.LevelAttributes.Strength);
        Assert.AreEqual(expectedAttributes.Dexterity, swashbuckler.LevelAttributes.Dexterity);
        Assert.AreEqual(expectedAttributes.Intelligence, swashbuckler.LevelAttributes.Intelligence);
    }

    [TestMethod]
    public void LevelUp_WhenCalled_IncreasesSwashbucklerLevelAndAttributes()
    {
        // Arrange
        Swashbuckler swashbuckler = new Swashbuckler("Captain Hook");
        int initialLevel = swashbuckler.Level;
        HeroAttribute initialAttributes = swashbuckler.LevelAttributes;

        // Act
        swashbuckler.LevelUp();

        // Assert
        Assert.AreEqual(initialLevel + 1, swashbuckler.Level);
        Assert.IsTrue(swashbuckler.LevelAttributes.Strength > initialAttributes.Strength);
        Assert.IsTrue(swashbuckler.LevelAttributes.Dexterity > initialAttributes.Dexterity);
        Assert.IsTrue(swashbuckler.LevelAttributes.Intelligence > initialAttributes.Intelligence);
    }

    // Additional tests for Swashbuckler class methods and behaviors can be added here.
}
