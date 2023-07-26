string food;
int seasoning = 0;

int count = 0;

int[] ingredientSelection = new int[5];



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
    
    //var choice = Console.ReadLine();
    
    if (Console.ReadLine() is string)
    {
        var finalChoice = Convert.ToInt32(choice);

        if (finalChoice == 1) { FoodMenu(); }
        //else if (choice == 2) { IngredientsMenu(); }
        else if (finalChoice == 3) { SeasoningMenu(); }
        else
        {
            Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
        }
    }
    else
    {
        Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
        MainMenu();
    }

    //Console.WriteLine(choice == 1);

    //if (choice != 1 ||  choice != 2 || choice != 3)
    //{
    //    Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
    //    MainMenu();
    //}
    //var finalChoice = Convert.ToInt32(choice);

    

    MainMenu();
}

    

void FoodMenu()
{
    Console.WriteLine("Please select a food option");
    Console.WriteLine("1 for soup, 2 for stew and 3 for gumbo");
    Console.WriteLine("What would you like to make?");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1) { food = "soup."; }
    else if (choice == 2) { food = "stew."; }
    else if (choice == 3) { food = "gumbo"; }
    else 
    {
    Console.WriteLine("Please select a valid choice. Select 1, 2, or 3 ");
    FoodMenu();
    }
    
    MainMenu();
}

//void IngredientsMenu()
//{
//    Console.WriteLine("Please select ingredients for your food");
//    Console.WriteLine("1 - Mushrooms, 2 - Chicken, 3 - Carrots, 4 - Potatoes 5 - Done");
//    Console.WriteLine("What would you like to add to your food?");
//    choice = Convert.ToInt32(Console.ReadLine());
//    if (choice != 1 || choice != 2 || choice != 3 || choice != 4 || choice != 5)
//    {
//        Console.WriteLine("Please select a valid choice. Select 1, 2, 3, 4, 5 ");
//        IngredientsMenu();
//    }
//    else if (choice < 5)
//    {
//        for (int i = 0; i < ingredientSelection.Length; i++)
//        {
//            if (i != 0)
//            {
//                Console.WriteLine($"You have already selected{choice}");
//                Console.WriteLine(i);
//                break;
//            }
//            else
//            {
//                ingredientSelection[count] = choice;
//                count++;
//                break;
//            }
//        }
//    }
//    else if (food == 5)
//    {
//        MainMenu();
//    }
//}

void SeasoningMenu()
{
    Console.WriteLine("Building out Seasoning Menu");
    /*
     * TODO: BUILD THIS
     */
    MainMenu();
}

MainMenu();

enum food{soup, stew, gumbo}

enum ingredient{mushrooms, chicken, carrots, potatoes}

enum seasoning{spicy, salty, sweet}