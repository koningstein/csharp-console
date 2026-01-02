namespace Tamagotchi.Models;


public class Food
{
    public string Name { get; set; }
    public int EnergyGain { get; set; }

    public Food(string name, int energyGain)
    {
        this.Name = name;
        this.EnergyGain = energyGain;
    }
}
