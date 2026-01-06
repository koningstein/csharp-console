using Figgle.Fonts;
using Tamagotchi.Models;
using System.Linq;

Console.WriteLine(FiggleFonts.Standard.Render("Dino Shelter"));

// We maken een LEGE lijst aan.
List<DigitalPet> pets = new List<DigitalPet>();

bool appRunning = true;

while (appRunning)
{
    // Toon de status (bij start is count 0)
    Console.WriteLine($"\n--- HOOFDMENU ({pets.Count} dieren) ---");
    Console.WriteLine("1. Nieuw dier toevoegen");
    Console.WriteLine("2. Alle dieren tonen");
    Console.WriteLine("3. Dier zoeken & Selecteren");
    Console.WriteLine("Q. Stoppen");
    Console.Write("Maak uw keuze: ");

    string choice = Console.ReadLine().ToUpper();

    // Hieronder komt de switch...
    switch (choice)
    {
        case "1":
            Console.Write("Naam: ");
            string name = Console.ReadLine();

            Console.Write("Start Energie (0-100): ");
            string energyText = Console.ReadLine();
            int energy = int.Parse(energyText); // <-- Van tekst naar getal

            Console.Write("Start Honger (0-100): ");
            string hungerText = Console.ReadLine();
            int hunger = int.Parse(hungerText); // <-- Van tekst naar getal

            // We maken het dier met de ingevoerde waardes
            DigitalPet newPet = new DigitalPet(name, energy, hunger);

            // En voegen hem toe aan de lijst
            pets.Add(newPet);

            Console.WriteLine($"{name} is toegevoegd!");
            break;
        case "2":
            Console.WriteLine("\n--- OVERZICHT ---");

            // Loop door alle dieren die de gebruiker heeft toegevoegd
            foreach (DigitalPet pet in pets)
            {
                Console.WriteLine(pet.EnergyDisplay());
            }

            Console.WriteLine("Druk op ENTER om terug te gaan.");
            Console.ReadLine();
            break;

        case "Q":
            appRunning = false; // Stop de loop
            Console.WriteLine("Tot ziens!");
            break;
        case "3":
            Console.Write("Welk dier zoek je? Typ de naam: ");
            string searchName = Console.ReadLine();

            // LINQ QUERY:
            // Zoek in de lijst 'pets'.
            // Pak de EERSTE (First) die voldoet aan de eis, of geef NULL (Default) als hij niet bestaat.
            DigitalPet? foundPet = pets.FirstOrDefault(p => p.Name == searchName);

            if (foundPet != null)
            {
                // JA! We hebben hem gevonden.
                Console.WriteLine("\nGEVONDEN!");
                Console.WriteLine(foundPet.EnergyDisplay());

                // Hier kunnen we straks acties toevoegen, zoals voeren of slapen.
                Console.WriteLine("Druk op ENTER om terug te gaan.");
            }
            else
            {
                // NEE! Hij bestaat niet.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Helaas, geen dier gevonden met die naam.");
                Console.ResetColor();
            }
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Ongeldige keuze.");
            break;
    } // Einde switch
}