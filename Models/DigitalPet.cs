namespace Tamagotchi.Models;

/// <summary>
/// Represents a virtual pet with properties and behaviors such as energy, hunger, and sleep state.
/// </summary>
/// <remarks>Use the DigitalPet class to simulate a digital pet that can be named, track its energy and hunger
/// levels, and perform actions such as sleeping or renaming. The class provides methods to interact with and retrieve
/// information about the pet's current state. Energy and hunger values are automatically constrained within defined
/// limits.</remarks>
public class DigitalPet
{
    // constanten
    public const int MaxEnergy = 100;
    public const int MinEnergy = 0;
    public const int SleepEnergyGain = 20;
    // De gewone eigenschappen
    public string Name { get; private set; }
    private int _energy;
    public int Energy 
    {
        get
        {
            return _energy;
        }
        private set
        {
            if (value < MinEnergy)
            {
                _energy = 0;
            }
            else if (value > MaxEnergy)
            {
                _energy = MaxEnergy;
            }
            else
            {
                _energy = value;
            }
        }
    }
    public int Hunger { get; private set; }
    public bool IsSleeping { get; private set; }
    public DateTime BirthDate { get; }

    /// <summary>
    /// Initializes a new instance of the DigitalPet class with the specified name, energy, hunger, and sleep state.
    /// </summary>
    /// <remarks>The pet's birth date is set to the current date and time when the instance is
    /// created.</remarks>
    /// <param name="name">The name to assign to the digital pet. Cannot be null or empty.</param>
    /// <param name="energy">The initial energy level of the pet. Must be between 0 and 100. The default value is 50.</param>
    /// <param name="hunger">The initial hunger level of the pet. Must be between 0 and 100. The default value is 0.</param>
    /// <param name="isSleeping">A value indicating whether the pet starts in a sleeping state. The default value is <see langword="false"/>.</param>
    public DigitalPet(string name, int energy = 50, int hunger = 0, bool isSleeping = false)
    {
        this.Name = name;
        this.Energy = energy;
        this.Hunger = hunger;
        this.IsSleeping = isSleeping;
        this.BirthDate = DateTime.Now;
    }

    public string GetDescription()
    {
        return "Ik ben " + this.Name + " en ik heb " + this.Energy + " energie.";
    }

    public string EnergyDisplay()
    {
        // We plakken tekst en data aan elkaar
        return this.Name + " - Level: " + this.Energy + "/100";

    }

    public string Sleep()
    {
        this.IsSleeping = true;
        this.Energy += SleepEnergyGain;

        UpdateStatus();

        // We printen NIET hier, maar sturen de tekst terug
        return $"Zzz... Dat deed deugd! (+{SleepEnergyGain} Energie)";
    }

    public void UpdateStatus()
    {
        // Omdat we slapen, gaat de tijd voorbij en krijgen we honger.
        // Zet HIER je Breakpoint (F9) op de regel hieronder:
        this.Hunger += 5;
    }

    /// <summary>
    /// Renames the current object to the specified name if it is valid.
    /// </summary>
    /// <param name="newName">The new name to assign. Must not be null, empty, or consist only of white-space characters.</param>
    /// <returns>A message indicating whether the rename operation was successful. Returns a success message with the new name if
    /// the operation succeeds; otherwise, returns a message indicating the name was invalid and the original name is
    /// retained.</returns>
    public string Rename(string? newName)
    {
        if (!string.IsNullOrWhiteSpace(newName))
        {
            this.Name = newName;
            return $"Naam succesvol gewijzigd naar: {this.Name}";
        }
        else
        {
            return "Ongeldige naam! We houden de oude naam.";
        }
    }

    public string Feed(Food food)
    {
        this.Energy += food.EnergyGain;
        this.Hunger -= 10;

        if (this.Hunger < 0) this.Hunger = 0;

        return $"Nom nom! {this.Name} heeft een {food.Name} gegeten. (+{food.EnergyGain} Energie)";
    }

}