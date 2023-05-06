namespace DesignPatterns.Prototype;

public class Goblin : IEnemy
{
    private int _health;
    private readonly int _attackPower;
    
    public Goblin()
    {
        _health = 10;
        _attackPower = 2;
    }
    
    public Goblin(int health, int attackPower)
    {
        _health = health;
        _attackPower = attackPower;
    }
    
    public void Attack()
    {
        Console.WriteLine($"Goblin attacks for {_attackPower} damage!");
    }
    
    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"Goblin takes {damage} damage!");
    }
    
    public IEnemy Clone()
    {
        return new Goblin(_health, _attackPower);
    }
    
    public int GetHealth()
    {
        return _health;
    }
    
    public int GetAttackPower()
    {
        return _attackPower;
    }
}