using Figgle.Fonts;
using Tamagotchi.Models;

string banner = FiggleFonts.Standard.Render("Dino Game");
Console.WriteLine(banner);

DigitalPet dino = new DigitalPet("Rex", isSleeping: true);
//dino.Name = "Rex";

//Console.WriteLine("Poging 1: -50 energie");
//dino.SetEnergy(-50);

Console.WriteLine(dino.GetDescription());
Console.WriteLine(dino.EnergyDisplay());

Console.WriteLine(dino.Sleep());

DigitalPet fluffy = new DigitalPet(
    hunger: 10,
    isSleeping: false,
    name: "Fluffy",
    energy: 80
);
//Console.WriteLine("Poging 2: 200 energie");
//fluffy.SetEnergy(200);

Console.WriteLine(fluffy.GetDescription());
Console.WriteLine(fluffy.EnergyDisplay());

Food apple = new Food("Appel", 10);
Console.WriteLine("En we hebben eten: " + apple.Name);

Console.ReadLine();