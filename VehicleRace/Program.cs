using System;

Vehicle[] vehicles = new Vehicle[3];
vehicles[0] = new Car { Name = "스포츠카" };
vehicles[1] = new Airplane { Name = "보잉747" };
vehicles[2] = new Boat { Name = "요트"};

Console.WriteLine("=== 경주 시작 ===");
foreach (var vehicle in vehicles)
{
    vehicle.Move();
}
