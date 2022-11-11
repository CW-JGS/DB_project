namespace JevonsGame.Characters;

public abstract class Attack
{
    protected Attack(string attackName, float damage, string attackCry)
    {
        AttackName = attackName;
        Damage = damage;
        AttackCry = attackCry;
    }

    public String AttackName { get; set; }
    public String AttackCry { get; set; }
    public float Damage { get; set; }
}