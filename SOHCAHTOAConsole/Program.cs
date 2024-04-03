using SOHCAHTOABusLogic;

Main main = new Main();

Console.Write($"Enter Opposite: ");
main.opposite = Console.ReadLine();
Console.Write($"Enter Adjacent: ");
main.adjacent = Console.ReadLine();
Console.Write($"Enter Hypotenuse: ");
main.hypotenuse = Console.ReadLine();
Console.Write($"Enter Angle: ");
main.angle = Console.ReadLine();
Console.WriteLine("\n");

main.Home();

