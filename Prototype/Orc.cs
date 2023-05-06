namespace DesignPatterns.Prototype;

public class Orc : IEnemy
{
    private int _health;
    private readonly int _attackPower;
    
    public Orc()
    {
        _health = 20;
        _attackPower = 5;
    }
    
    public Orc(int health, int attackPower)
    {
        _health = health;
        _attackPower = attackPower;
    }
    
    public void Attack()
    {
        Console.WriteLine($"Orc attacks for {_attackPower} damage!");
    }
    
    public void TakeDamage(int damage)
    {
        _health -= damage;
        Console.WriteLine($"Orc takes {damage} damage!");
    }
    
    public IEnemy Clone()
    {
        return new Orc(_health, _attackPower);
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