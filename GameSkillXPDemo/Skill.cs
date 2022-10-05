namespace GameSkillXPDemo;

public class Skill
{
    public SkillXpSystem XpSystem { get; set; }

    public int SkillLevel { get { return XpSystem.Level; }}
    
    public Skill()
    {
        XpSystem = new SkillXpSystem();
    }
    
    public void Gain(int xp)
    {
        XpSystem.AddXp(xp);
    }
}
