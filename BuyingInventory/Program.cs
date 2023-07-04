byte rope = 10;
byte torches = 15;
byte climbingEquipment = 25;
byte cleanWater = 1;
byte machete = 20;
byte canoe = 200;
byte foodSupplies = 1;
int menuChoice= 0;
string menuSelection;
string name;

Console.WriteLine("Hello, Please enter your name: ");
name = Console.ReadLine();

while (menuChoice != 8)
{


Console.WriteLine("The following items are available: ");
Console.WriteLine(
    "1 - Rope\n" +
    "2 - Torches\n" +
    "3 - Climbing Equipment\n" +
    "4 - Clean Water\n" +
    "5 - Machete\n" +
    "6 - Canoe\n" +
    "7 - Food Supplies\n" +
    "8 - Exit\n" +
    "What number do you want to see the price of? ");

menuSelection = Console.ReadLine();

menuChoice = Convert.ToInt32(menuSelection);

//discount menu
if(name == "bob")
    {
        switch (menuChoice)
        {
            case 1: Console.WriteLine($"Rope cost {rope / 2} gold"); break;
            case 2: Console.WriteLine($"Torches cost {torches / 2} gold"); break;
            case 3: Console.WriteLine($"Climbing Equipment costs {climbingEquipment / 2} gold"); break;
            case 4: Console.WriteLine($"Clean Water {cleanWater / 2} gold"); break;
            case 5: Console.WriteLine($"Machete costs {machete / 2} gold"); break;
            case 6: Console.WriteLine($"Canoe cost {canoe / 2} gold"); break;
            case 7: Console.WriteLine($"Food Supplies costs {foodSupplies / 2} gold"); break;
            default: Console.WriteLine("Please make a valid choice"); break;
        }

    }
    else
    {

        switch (menuChoice)
        {
            case 1: Console.WriteLine($"Rope cost {rope} gold"); break;
            case 2: Console.WriteLine($"Torches cost {torches} gold"); break;
            case 3: Console.WriteLine($"Climbing Equipment costs {climbingEquipment} gold"); break;
            case 4: Console.WriteLine($"Clean Water {cleanWater} gold"); break;
            case 5: Console.WriteLine($"Machete costs {machete} gold"); break;
            case 6: Console.WriteLine($"Canoe cost {canoe} gold"); break;
            case 7: Console.WriteLine($"Food Supplies costs {foodSupplies} gold"); break;
            default: Console.WriteLine("Please make a valid choice"); break;
        }
    }



    Console.WriteLine("Press any key to continue");
    Console.ReadKey(true);
    Console.Clear();
}