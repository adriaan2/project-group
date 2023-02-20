public class Quest
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }
    public Item RewardItem { get; set; }
    public Weapon RewardWeapon { get; set; }
    public List<CountedItem> QuestCompletionItems{ get; set; }

    public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold, Item rewardItem, Weapon rewardWeapon)
    {
        ID = id;
        Name = name;
        Description = description;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        RewardItem = rewardItem;
        RewardWeapon = rewardWeapon;
        QuestCompletionItems =new List<CountedItem>();
    }
}