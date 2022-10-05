namespace GameSkillXPDemo;

public class SkillXpSystem
{
    public int Level { get; set; } = 0;

    private int _totalXp = 0;

    private int _xpLeftToLevelUp { get; set; } = 5000;

    private  int _xpOfLevel { get; set; } = 5000;

    private double _xpExponent = 1.1;


    public void AddXp(int xp)
    {
        _totalXp += xp;
        _xpLeftToLevelUp -= xp;
        while(_xpLeftToLevelUp <= 0)
        {
            LevelUp();
            _xpLeftToLevelUp += _xpOfLevel;
        }
    }

    private void LevelUp()
    {
        Level++; 
        XpGrowth();
    }
    
    private void XpGrowth() => 
        _xpOfLevel = (int)Math.Truncate(_xpOfLevel*_xpExponent);
    
}
