namespace Task29;

public class Soldier
{
    public int HP { get; set; }
    public string Skill { get; set; }
    public int Damage { get; set; }
    
    public Soldier(int hp, string skill, int damage)
    {
        HP = hp;
        Skill = skill;
        Damage = damage;
    }

    public void TakeDamageSolder(int damage)
    {
        HP -= damage;
        if (HP < 0) HP = 0;
    }
}