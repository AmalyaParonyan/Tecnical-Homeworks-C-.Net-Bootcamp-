using System;
public class program1 {
    public static void Main() {
        string userName;
        string password;

        Console.WriteLine(" * Default userName -> firstName_LastName, Password -> 1712 * \n");
        Console.WriteLine("Username & password check\n");
        
        // ცდების რაოდენობა
        int numberOfTrials = 0;

        do { 
            Console.Write("Enter user's name -> ");
            userName = Console.ReadLine();

            Console.Write("Enter password -> ");
            password = Console.ReadLine();

            if (userName != "firstName_LastName" || password != "1712") {
                numberOfTrials++;
            }
            else { 
                numberOfTrials = 1;
            }

        }
        while ((userName != "firstName_LastName" || password != "1712") && (numberOfTrials != 5));

        if (numberOfTrials == 5)
            Console.WriteLine("Attempt five times. Error message\n");
        else
            Console.WriteLine("Entered successfully\n");
    }
}