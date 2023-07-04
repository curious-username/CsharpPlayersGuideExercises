int[] test = new int[5];

for(int i = 0; i < test.Length; i++)
{
    test[i] = i;
    
}

int[] scores = test[0..^1];


Console.WriteLine(scores[^1]);