bool Continue = true;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string ContinueInput = Console.ReadLine();
    if (ContinueInput == "y")
    {
        Continue = true;
    }
    else if (ContinueInput == "n")
    {
        Continue = false;
    }
} while (Continue == true);
