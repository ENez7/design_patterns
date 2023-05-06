namespace DesignPatterns.Prototype;

public abstract class PrototypeClient
{
    // Think of this prototype as a spawner of enemies
    // The main idea of this pattern is to create new objects by cloning other objects
    // This is useful when the cost of creating a new object is expensive
    // In this example, we are creating a new enemy by cloning an existing enemy
    
    public static void Run()
    {
        // These are the prototypes or the ones we are going to clone
        var orc = new Orc();
        var goblin = new Goblin();
        
        // Orc by default has 20 health and 5 attack power
        // Imagine that you want to create a spawner of damaged orc
        var damagedOrc = new Orc(5, 10);
        
        // These are the clones
        var orcsClones = new List<Orc>();
        var goblinsClones = new List<Goblin>();
        var damagedOrcsClones = new List<Orc>();
        
        // We are going to create 10 clones of each enemy
        for (var i = 0; i < 5; i++)
        {
            orcsClones.Add((Orc) orc.Clone());
            goblinsClones.Add((Goblin) goblin.Clone());
            damagedOrcsClones.Add((Orc) damagedOrc.Clone());
        }
        
        // Now you can attack the enemies and see that they have different stats
        // This is because they are different objects
        orcsClones.ElementAt(0).TakeDamage(5);
        orcsClones.ElementAt(1).TakeDamage(3);
        orcsClones.ElementAt(2).TakeDamage(4);
        orcsClones.ElementAt(3).TakeDamage(2);
        orcsClones.ElementAt(4).TakeDamage(1);
        
        goblinsClones.ElementAt(0).TakeDamage(4);
        goblinsClones.ElementAt(1).TakeDamage(3);
        goblinsClones.ElementAt(2).TakeDamage(2);
        goblinsClones.ElementAt(3).TakeDamage(1);
        goblinsClones.ElementAt(4).TakeDamage(5);
        
        // Now you can see that the stats are different
        foreach (var enemy in orcsClones)
        {
            Console.WriteLine($"Orc health: {enemy.GetHealth()}");
        }
        foreach (var enemy in goblinsClones)
        {
            Console.WriteLine($"Goblin health: {enemy.GetHealth()}");
        }
        foreach (var enemy in damagedOrcsClones)
        {
            Console.WriteLine($"Damaged Orc health: {enemy.GetHealth()}");
        }
    }
}