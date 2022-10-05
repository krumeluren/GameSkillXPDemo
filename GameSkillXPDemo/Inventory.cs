
namespace GameSkillXPDemo;

public class Inventory
{
    public int Volume { get; set; }
    public int Slots { get; set; }

    private List<Item> Items { get; set; } = new List<Item>();

    public bool ExistsIn(Item item)
    {
        return Items.Exists(x => x == item);
    }

    public void Add(Item item)
    {
        if (Items.Count >= Slots)
            return;

        Items.Add(item);
    }
}
