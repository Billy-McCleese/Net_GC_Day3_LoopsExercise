bool AccessGranted = false;
int NumOfAttempts = 1;
while (!AccessGranted && NumOfAttempts <= 5)
{
    Console.WriteLine("Please enter a passcode: ");
    int Passcode = int.Parse(Console.ReadLine());
    if (Passcode == 13579)
    {
        Console.WriteLine("Access Granted!");
        AccessGranted = true;
    }

    else if (Passcode != 13579)
    {
        NumOfAttempts += 1;
        Console.WriteLine("Access Denied!");
        AccessGranted = false;
        if (NumOfAttempts == 6)
        {
            Console.WriteLine("Too many wrong attempts, goodbye!");
        }
    }
}