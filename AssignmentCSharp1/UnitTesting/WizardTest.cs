using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class WizardTests
{
    [TestMethod]
    public void CreateWizard_WithNameAndAttributes_CreatesWizardWithCorrectAttributes()
    {
        // Arrange
        string wizardName = "Voldemort";
        int expectedLevel = 1;
        HeroAttribute expectedAttributes = new HeroAttribute(2, 3, 10);

        // Act
        Wizard wizard = new Wizard(wizardName);

        // Assert
        Assert.AreEqual(wizardName, wizard.Name);
        Assert.AreEqual(expectedLevel, wizard.Level);
        Assert.AreEqual(expectedAttributes.Strength, wizard.LevelAttributes.Strength);
        Assert.AreEqual(expectedAttributes.Dexterity, wizard.LevelAttributes.Dexterity);
        Assert.AreEqual(expectedAttributes.Intelligence, wizard.LevelAttributes.Intelligence);
    }

    [TestMethod]
    public void LevelUp_WhenCalled_IncreasesWizardLevelAndAttributes()
    {
        // Arrange
        Wizard wizard = new Wizard("Merlin");
        int initialLevel = wizard.Level;
        HeroAttribute initialAttributes = wizard.LevelAttributes;

        // Act
        wizard.LevelUp();

        // Assert
        Assert.AreEqual(initialLevel + 1, wizard.Level);
        Assert.IsTrue(wizard.LevelAttributes.Strength > initialAttributes.Strength);
        Assert.IsTrue(wizard.LevelAttributes.Dexterity > initialAttributes.Dexterity);
        Assert.IsTrue(wizard.LevelAttributes.Intelligence > initialAttributes.Intelligence);
    }

    // Additional tests for Wizard class methods and behaviors can be added here.
}
