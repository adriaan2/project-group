public class Weapon
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int MinimumDamage { get; set; }
    public int MaximumDamage { get; set; }

    public Weapon(int id, string name, string description, int minimumDamage, int maximumDamage)
    {
        ID = id;
        Name = name;
        Description = description;
        MinimumDamage = minimumDamage;
        MaximumDamage = maximumDamage;
    }
}