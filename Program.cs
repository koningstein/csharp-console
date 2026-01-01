DigitalPet dino = new DigitalPet("Rex", isSleeping: true);
//dino.Name = "Rex";

//Console.WriteLine("Poging 1: -50 energie");
//dino.SetEnergy(-50);

Console.WriteLine(dino.GetDescription());
Console.WriteLine(dino.EnergyDisplay);

DigitalPet fluffy = new DigitalPet(
    hunger: 10,
    isSleeping: false,
    name: "Fluffy",
    energy: 80
);
//Console.WriteLine("Poging 2: 200 energie");
//fluffy.SetEnergy(200);

Console.WriteLine(fluffy.GetDescription());

Console.ReadLine();
Console.WriteLine(fluffy);

Console.ReadLine();