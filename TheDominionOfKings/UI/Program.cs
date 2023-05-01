int usersTotalScore = 0;

Console.Write("Enter how many provinces do you have ");
int amountOfProvinces = int.Parse(Console.ReadLine());
usersTotalScore += amountOfProvinces * 6;
Console.Write("Enter how many duchies do you have ");
int amountOfDuchies = int.Parse(Console.ReadLine());
usersTotalScore += amountOfDuchies * 3;
Console.Write("Enter how many estates do you have? ");
int amountOfEstates = int.Parse(Console.ReadLine());
usersTotalScore += amountOfEstates;

Console.WriteLine("Your score is " + usersTotalScore);