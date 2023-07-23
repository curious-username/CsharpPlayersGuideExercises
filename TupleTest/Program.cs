//(string, int, int) score = (Name: "Bob", Age: 99, Skill: 9001);

//Console.WriteLine($"Your name is {score.Item1}, you are {score.Item2} and you have a skill level of {score.Item3}");


void TupleTest((string, int, int) score)
{
    Console.Write($"You are {score.Item1} in {score.Item2} place with a score of {score.Item3}");
}

(string, int, int) playerScore = ("bob", 1, 134543);

TupleTest(playerScore);