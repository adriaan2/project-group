public class Monster
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string PluralName { get; set; }
    public int MaximumHitPoints { get; set; }
    public int CurrentHitPoints { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperiencePoints { get; set; }
    public int RewardGold { get; set; }

    public CountedItemList Loot { get; set; }

    public Monster(int id, string name, string pluralName, int maximumHitPoints, int maximumDamage, 
                   int rewardExperiencePoints, int rewardGold, int loot)
    {
        ID = id;
        Name = name;
        PluralName = pluralName;
        MaximumHitPoints = maximumHitPoints;
        MaximumDamage = maximumDamage;
        RewardExperiencePoints = rewardExperiencePoints;
        RewardGold = rewardGold;
        Loot = loot;

        CurrentHitPoints = MaximumHitPoints;
    }
}
