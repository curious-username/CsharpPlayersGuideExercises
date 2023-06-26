int chocolateEggsCollected;
int numofSisters = 4;
 

Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("How many eggs have you gathered today?");
chocolateEggsCollected = Convert.ToInt32(Console.ReadLine());
var eggsTotal = chocolateEggsCollected / numofSisters;
var leftOver = chocolateEggsCollected % numofSisters;

Console.WriteLine("You have collected " + chocolateEggsCollected + "chocolate eggs.");
Console.WriteLine($"There are {eggsTotal, 20} per person and {leftOver, 20} leftover");
Console.WriteLine("Press any key to quit");
Console.Beep();
Console.ReadKey(true);

