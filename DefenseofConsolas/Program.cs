
int row;
int column;

Console.Title = "Defense of Consolas";


Console.WriteLine("Target Row? ");
row = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Target Column? ");
column = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("\nDeploy to: ");
Console.WriteLine($"{row}, {column + 1}");
Console.WriteLine($"{row}, {column - 1}");
Console.WriteLine($"{row - 1}, {column}");
Console.WriteLine($"{row + 1}, {column}");
Console.Beep(400, 1000);


