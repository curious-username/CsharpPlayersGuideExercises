int food, seasoning, choice;
int[] ingredients;



void Recipe((food, ingredient, seasoning) soup)
{

}

void MainMenu()
{
    Console.WriteLine("Welcome to the Soup Maker");
    Console.WriteLine("Select one type, what ingredients you want, and the flavor you are achieving\n");
    Console.WriteLine("Select an option to start your creation");
    Console.WriteLine("1.) Food");
    Console.WriteLine("2.) Ingredients");
    Console.WriteLine("3.) Seasoning");
    Console.WriteLine("Select an option");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice != 1 || choice != 2 || choice != 3)
    {
        Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
        MainMenu();
    }
}

MainMenu();

void FoodMenu()
{
    Console.WriteLine("Please select a food option");
    Console.WriteLine("1 for soup, 2 for stew and 3 for gumbo");
    Console.WriteLine("What would you like to make?");
    food = Convert.ToInt32(Console.ReadLine());
    if(food != 1 || food != 2 || food != 3)
    {
        Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
        FoodMenu();
    }
    else
    {
        MainMenu();
    }
}

void IngredientsMenu()
{
    Console.WriteLine("Please select ingredients for your food");
    Console.WriteLine("1 - Mushrooms, 2 - Chicken, 3 - Carrots, 4 - Potatoes 5 - Done");
    Console.WriteLine("What would you like to add to your food?");
    food = Convert.ToInt32(Console.ReadLine());
    if (food != 1 || food != 2 || food != 3 || food != 4 || choice != 5)
    {
        Console.WriteLine("Please select a valid choice. Select 1, 2, 3, 4, 5 ");
        IngredientsMenu();
    }
    else if(food == 5)
    {
        MainMenu();
    }
}


enum food{soup, stew, gumbo}

enum ingredient{mushrooms, chicken, carrots, potatoes}

enum seasoning{spicy, salty, sweet}