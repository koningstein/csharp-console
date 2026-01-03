using Figgle.Fonts;
using Tamagotchi.Models;

// 1. Banner tonen
string banner = FiggleFonts.Standard.Render("Dino Game");
Console.WriteLine(banner);

// --- DINO 1 (Rex) ---
// We maken hem aan (met een tijdelijke naam 'Rex')
DigitalPet dino = new DigitalPet("Rex", isSleeping: true);

Console.WriteLine("----------------------------------");
Console.WriteLine($"Er is een nieuwe dino gevonden! (Standaard naam: {dino.Name})");
Console.Write("Hoe wil je hem noemen? ");

// INPUT VRAGEN
// Hier gebruiken we string? omdat Console.ReadLine leeg kan zijn.
string? inputDino = Console.ReadLine();
Console.WriteLine(dino.Rename(inputDino)); // Veilige update

// DETAILS TONEN (Na de input)
Console.WriteLine(dino.GetDescription());
Console.WriteLine(dino.EnergyDisplay());
Console.WriteLine(dino.Sleep()); // Actie uitvoeren


// --- DINO 2 (Fluffy) ---
// We maken een tweede dino aan met andere stats
DigitalPet fluffy = new DigitalPet(
    hunger: 10,
    isSleeping: false,
    name: "Fluffy",
    energy: 80
);

Console.WriteLine("\n----------------------------------");
Console.WriteLine($"Er komt een tweede dino aanlopen... (Standaard naam: {fluffy.Name})");
Console.Write("Hoe wil je deze noemen? ");

// INPUT VRAGEN
string? inputFluffy = Console.ReadLine();
Console.WriteLine(fluffy.Rename(inputFluffy)); // Veilige update

// DETAILS TONEN (Hetzelfde rijtje als bij dino 1)
Console.WriteLine(fluffy.GetDescription());
Console.WriteLine(fluffy.EnergyDisplay());
// (Fluffy laten we niet slapen, die is wakker)


// --- OVERIGE CODE ---
Food apple = new Food("Appel", 10);
Console.WriteLine("\nEn we hebben eten: " + apple.Name);

// De Cheater test (om te zien of validatie werkt)
DigitalPet cheater = new DigitalPet("Cheater", 9999);
Console.WriteLine(cheater.EnergyDisplay());

// Scherm open houden
Console.ReadLine();