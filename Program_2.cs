using System;
public class program2 {
    public static void Main(string[] args)  {

        long number;

        // Why 10? because there are total 10 digits between 0 to 9, and any
        // combination of digits is decimal number.
        int[] array = new int[10];

        Console.Write("Enter the number -> ");
        number = int.Parse(Console.ReadLine());

        // Why /2 ? Because binary number is a base 2 number, it is 0 or 1,
        // and any combination of 0 and 1 is binary number
        long i;
        for (i = 0; number > 0; i++) {
            array[i] = number % 2;
            number /= 2;
        }

        Console.Write("Binary is -> ");
        for (i -= 1; i >= 0; i--){
            Console.Write(array[i]);
            
        }
        Console.WriteLine("\n\n");
    }
}