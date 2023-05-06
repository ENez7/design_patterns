namespace DesignPatterns.Prototype;

public interface IEnemy
{
    IEnemy Clone();
    int GetHealth();
    int GetAttackPower();
}