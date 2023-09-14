using System;

class Program
{
    
    /// The entry point of the Hero RPG application
    /// <param name="args">Command-line arguments (not used).</param>
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to Al Qaeda Training Facility!");

        // Create and test heroes
        TestHero(new Wizard("Voldemort"));
        TestHero(new Archer("Robin Hood"));
        TestHero(new Swashbuckler("Krillin"));
        TestHero(new Barbarian("Broly"));

        // Program completed
        Console.WriteLine("\nThank you for playing!");
    }

   
    /// Test a hero by leveling up, equipping items, and displaying information.
    /// <param name="hero">The hero to test.</param>
    static void TestHero(Hero hero)
    {
        try
        {
            // Level up the hero
            hero.LevelUp();
            Console.WriteLine($"Hero {hero.Name} leveled up!");

            // Create and equip a weapon
            Weapon weapon = new Weapon("Sword", 1, Slot.Weapon, WeaponType.Sword, 10);
            hero.Equip(weapon);
            Console.WriteLine($"Hero {hero.Name} equipped a sword!");

            // Create and equip armor
            Armor armor = new Armor("Plate Armor", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(5, 0, 0));
            hero.Equip(armor);
            Console.WriteLine($"Hero {hero.Name} equipped plate armor!");

            // Display hero information
            Console.WriteLine($"\nHero Information for {hero.Name}:");
            Console.WriteLine(hero.Display());
        }
        catch (CustomException ex)
        {
            // Handle custom exceptions
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
