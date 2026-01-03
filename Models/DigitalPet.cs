namespace Tamagotchi.Models;

public class DigitalPet
{
    // De gewone eigenschappen
    public string Name { get; private set; }
    public int Energy { get; private set; }
    public int Hunger { get; private set; }
    public bool IsSleeping { get; private set; }


    public DigitalPet(string name, int energy = 50, int hunger = 0, bool isSleeping = false)
    {
        this.Name = name;
        this.Energy = energy;
        this.Hunger = hunger;
        this.IsSleeping = isSleeping;
    }

    // 1. De Validatie Methode (De Setter)
    // We vragen om een 'amount' (hoeveelheid)
    public void SetEnergy(int amount)
    {
        // 2. De Controle
        if (amount < 0)
        {
            Console.WriteLine("Foutje! Energie mag niet negatief zijn.");
            Console.WriteLine("We zetten de energie op 0.");
            this.Energy = 0; // We corrigeren de fout
        }
        else if (amount > 100)
        {
            Console.WriteLine("Wow, dat is te veel! Maximaal 100.");
            this.Energy = 100; // We begrenzen het op 100
        }
        else
        {
            // 3. Alles is veilig, sla het op!
            this.Energy = amount;
        }
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
        this.Energy += 20;

        UpdateStatus();

        // We printen NIET hier, maar sturen de tekst terug
        return "Zzz... Dat deed deugd! (+20 Energie)";
    }

    public void UpdateStatus()
    {
        // Omdat we slapen, gaat de tijd voorbij en krijgen we honger.
        // Zet HIER je Breakpoint (F9) op de regel hieronder:
        this.Hunger += 5;
    }

    public void Rename(string newName)
    {
        // Later kunnen we hier checks toevoegen (bijv: check op scheldwoorden)
        this.Name = newName;
    }

}