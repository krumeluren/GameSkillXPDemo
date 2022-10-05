
namespace GameSkillXPDemo;

public class Item
{
    public int BaseDamage { get; set; } = 1;
    public int Damage { get; set; } = 1;
    public int BaseSpeed { get; set; } = 1;
    public int Speed { get; set; } = 1;
    public int BaseRange { get; set; } = 1;
    public int Range { get; set; } = 1;
    public int BaseDurabillity { get; set; } = 100;
    public int Durabillity { get; set; } = 100;
    
    public bool IsTwoHand { get; set; } = false;
    public bool IsEquippable { get; set; } = false;

    public Skill Skill { get; set; }

    public Item()
    {

    }
}
