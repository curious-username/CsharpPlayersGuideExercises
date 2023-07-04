Console.Title = "The Laws of Freach";

int[] nums = new int[5];
int[] nums2 = new int[5];
int count = 0;
Console.WriteLine("We will enter five numbers, enter your first number and press enter");


foreach(var i in nums)
{
    // index 0

    nums[count] = Convert.ToInt32(Console.ReadLine());
    count++;
    Console.WriteLine($"Enter the {count} number");
}
count = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    nums[i] = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"Enter the {i + 1} number");
//}

//for (int i = 0; i < nums2.Length; i++)
//{
//    nums2[i] = nums[i];
//}

foreach(var i in nums)
{
    
    nums2[count] = i;
    count++;
}

foreach (int i in nums)
{
    Console.Write(i + " ");
}
Console.WriteLine();

foreach (int i in nums2)
{
    Console.Write(i + " ");
}