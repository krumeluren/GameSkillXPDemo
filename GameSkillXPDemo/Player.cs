
namespace GameSkillXPDemo;

public class Player
{
    public Item MainHand { get; set; }
    public Item OffHand { get; set; } = new ();
    public Inventory Inventory { get; set; }

    public Player()
    {
        
    }

    public void DoAttack()
    {
        var sl = MainHand.Skill.SkillLevel;

        MainHand.Damage = MainHand.BaseDamage + (sl * MainHand.BaseDamage) / (MainHand.BaseDamage + sl);

        Console.Write(MainHand.Damage);
        
        MainHand.Durabillity -= 1;
        OffHand.Skill.Gain(100);
        MainHand.Skill.Gain(100);      
    }

    public void EquipMainHand(Inventory inv, Item item)
    {
        if (!item.IsEquippable)
            return;
        if (!inv.ExistsIn(item))
            return;

        if (item.IsTwoHand)
        {
            Unequip(inv, OffHand);
            Unequip(inv, MainHand);
            MainHand = item;
        }
        else
        {
            Unequip(inv, MainHand);
            MainHand = item;
        }
    }  

    public void EquipOffHand(Inventory inv, Item item)
    {
        if (!item.IsEquippable)
            return;
        if (item.IsTwoHand)
            return;
        if (!inv.ExistsIn(item))
            return;
        if (MainHand.IsTwoHand)
            Unequip(inv, MainHand);
        
        Unequip(inv, OffHand);
        OffHand = item;
    }

    private void Unequip(Inventory inv, Item item)
    {
        if (item.GetType == new EmptyItem().GetType)
            return;
        
        Inventory.Add(item);
        item = new EmptyItem();
    }
}