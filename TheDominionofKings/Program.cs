int provinces;
int dutches;
int estates;

string king;

Console.WriteLine("How many provinces do you have?");
provinces = Console.Read();
provinces *= 6;

Console.WriteLine("How many dutches do you have?");
dutches = Console.Read();
dutches *= 3;

Console.WriteLine("How many estates do you have?");
estates = Console.Read();


Console.WriteLine("What is your last name your grace?");
king = Console.ReadLine();

Console.WriteLine($"Lord {king} your total points is {provinces + dutches + estates} ");