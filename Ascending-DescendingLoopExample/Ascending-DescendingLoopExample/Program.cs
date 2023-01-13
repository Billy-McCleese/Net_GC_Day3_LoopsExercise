string UserContinue = null;
do
{
    Console.WriteLine("Please enter a number");
    int userNumber = int.Parse(Console.ReadLine());
    for (int i = userNumber; i >= 0; i--)
    {
        Console.WriteLine(i);
    }
    for (int i = 0; i <= userNumber; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Do you want to continue?");
    UserContinue = Console.ReadLine();
} while (UserContinue == "y");
