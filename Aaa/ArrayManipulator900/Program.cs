// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // Create Original Array & Temporary Array
        int[] originalArray = [ 90, 70, 50, 60, 80, 85 ];
        int[] tempArray = new int[originalArray.Length + 1];

        //
        bool getUserIndex = false;
        bool getUserValue = false;

        // Greet User & Describe Program
        Console.WriteLine("\n\tHello World!\n\n\tWelcome to the Array Manipulator\n\tHere is the Original Array:");
        Console.Write("\t    ");
        for (int i = 0; i < originalArray.Length; i++) 
        {
            Console.Write(originalArray[i] + " ");
        }
        Console.WriteLine("\n\n\tPlease Chose a manipulation option from the list below:");
        Console.Write("\t1. Append\n\t2. Insert\n\t3. Delete (NOT IMPLEMENTED)\n\tChoice: ");

        // Get User Input
        try
        {
            var userChoice = Console.ReadLine();
            int userChoiceInt = Convert.ToInt32(userChoice);

            // Check userChoice against implemented options
            switch (userChoiceInt)
            {
                // Append Input Number to List
                case 1:
                    getUserValue = true;
                    return;
                // Insert Input Number to List
                case 2:
                    getUserIndex = true;
                    getUserValue = true;
                    return;
                // Delete
                case 3:
                    getUserIndex = true;
                    return;
                // Anything Else
                default:
                    throw new Exception("Not a Valid Option.");
            }

        }
        catch (Exception e) 
        {
            Console.WriteLine("\n\tError Message: \n\n{0}\n", e);
        }

        if (getUserValue == true) 
        {
            if(getUserIndex == true) 
            { 

            }
            else
            {

            }
        }
        else
        {

        }

        // End of Program Key Hold
        Console.WriteLine("\nPress any key to exit");
        Console.ReadKey();
    }
}