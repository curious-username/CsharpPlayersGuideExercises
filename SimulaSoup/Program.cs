string food;
int seasoning = 0;
bool isIngredientPresent = false;
int count = 0;

string[] ingredientSelection = new string[5];



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
    Console.WriteLine("4.) Create Food");
    Console.WriteLine("Select an option");

    string value = Console.ReadLine();
    
    if(value == "1") { FoodMenu(); }
    else if(value == "2") { IngredientsMenu(); }
    else if(value == "3") { SeasoningMenu(); }
    else if(value == "4") { CreateFood(); }
    else
    {
        Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
        MainMenu();
    }
        MainMenu();
}

    

void FoodMenu()
{
    Console.WriteLine("Please select a food option");
    Console.WriteLine("1 for soup, 2 for stew and 3 for gumbo");
    Console.WriteLine("What would you like to make?");
    string choice = Console.ReadLine();

    if (choice == "1") { food = "soup."; }
    else if (choice == "2") { food = "stew."; }
    else if (choice == "3") { food = "gumbo"; }
    
    else 
    {
    Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
    FoodMenu();
    }

    Console.WriteLine($"You selected {food}.");
    MainMenu();
}

void IngredientsMenu()
{
    Console.WriteLine("Please select ingredients for your food");
    Console.WriteLine("1 - Mushrooms, 2 - Chicken, 3 - Carrots, 4 - Potatoes 5 - Done");
    Console.WriteLine("What would you like to add to your food?");
    string choice = Console.ReadLine();

    if (choice == "1") { choice = "Mushrooms"; }
    else if (choice == "2") { choice = "Chicken"; }
    else if (choice == "3") { choice = "Carrots"; }
    else if (choice == "4") { choice = "Potatoes"; }
    else if (choice == "5") { MainMenu(); }
    else
    {
        Console.WriteLine("Please select a valid choice. Select 1, 2, 3, 4, or 5 \n");
        IngredientsMenu();
    }

    for(int i = 0; i < ingredientSelection.Length; i++)
    {
        if (ingredientSelection[i] == choice)
        {
            Console.WriteLine($"You have already selected {choice}\n");
            isIngredientPresent = true;
            break;
        }
        else
        {
            isIngredientPresent = false;
        }
    }

    if(isIngredientPresent == false && count < ingredientSelection.Length)
    {
        if(choice != null)
        {
            ingredientSelection[count] = choice;
            Console.WriteLine($"You have selected {choice}\n");
            count++;
        }
    }

    IngredientsMenu();
}

void SeasoningMenu()
{
    Console.WriteLine("Building out Seasoning Menu");
    /*
     * TODO: BUILD THIS
     */
    MainMenu();
}

void CreateFood()
{
    /*
     * TO DO: BUILD THIS
     * Ensure there are null checks including the ingredients array
     * return to food menu and give error of "need to select whatever based on whatever is null" 
     * If all elements in the ingredient array return null is the only time it will return the error.
     * if all checks done, return the message recommended by book
}

MainMenu();

enum food{soup, stew, gumbo}

enum ingredient{mushrooms, chicken, carrots, potatoes}

enum seasoning{spicy, salty, sweet}