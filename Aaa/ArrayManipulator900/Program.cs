// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        // Create Original Array & Temporary Array
        int[] originalArray = [ 90, 70, 50, 60, 80, 85 ];
        int[] tempAddArray = new int[originalArray.Length + 1];
        int[] tempSubArray = new int[originalArray.Length - 1];

        // Set some User-determined variables
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
        Console.Write("\t1. Append\n\t2. Insert\n\t3. Delete\n\tChoice: ");

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
                    // Debug lines left in bug commented out in event of future need
                    // Original issue was useage of "return;" rather than "break;"
                    //Console.WriteLine("\nDebug Test\n");
                    getUserValue = true;
                    break;
                // Insert Input Number to List
                case 2:
                    //Console.WriteLine("\nDebug Test\n");
                    getUserIndex = true;
                    getUserValue = true;
                    break;
                // Delete
                case 3:
                    //Console.WriteLine("\nDebug Test\n");
                    getUserIndex = true;
                    break;
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
            // Check which function to perform
            if(getUserIndex == true) 
            {
                // Linear Table INSERT
                try
                {
                    // Display Array with index numbers
                    Console.Write("\n\tIndex:  ");
                    for (int i = 0; i < originalArray.Length; i++)
                    {
                        Console.Write(i + "  ");
                    }
                    Console.Write("\n\tValue: ");
                    for (int i = 0; i < originalArray.Length; i++)
                    {
                        Console.Write(originalArray[i] + " ");
                    }

                    // Get insert index & value
                    Console.WriteLine("\n\nPlease Enter a zero-indexed location to insert your number");
                    Console.Write("Insertion Index: ");
                    int userInsertionIndex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease Enter an integer value to insert");
                    Console.Write("Insertion Value: ");
                    int userNum = Convert.ToInt32(Console.ReadLine());

                    // Insert
                    if (userInsertionIndex == 0)
                    {
                        tempAddArray[0] = userNum;
                        for (int i = 1; i < tempAddArray.Length; i++)
                        {
                            tempAddArray[i] = originalArray[i - 1];
                        }
                    }
                    else
                    {
                        if (originalArray.Length == userInsertionIndex)
                        {
                            for (int i = 0; i < originalArray.Length; i++)
                            {
                                tempAddArray[i] = originalArray[i];
                            }

                            tempAddArray[userInsertionIndex] = userNum;
                        }
                        else
                        {
                            for (int i = 0, x = 0; x < originalArray.Length; i++, x++)
                            {
                                if (i == userInsertionIndex)
                                {
                                    tempAddArray[i] = userNum;
                                    i++;
                                }

                                tempAddArray[i] = originalArray[x];

                            }
                        }
                    }

                    // Display New Array

                    Console.WriteLine("\n\nNew Array:");
                    Console.Write("\t    ");

                    for (int i = 0; i < tempAddArray.Length; i++)
                    {
                        Console.Write(tempAddArray[i] + " ");
                    }

                    // Over-write original array
                    originalArray = tempAddArray;

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\tError Message: \n\n{0}\n", e);
                }
            }
            else // User Index == False. 
            {
                // Linear Table APPEND
                try
                {
                    // Copy Original Array to Temp Array
                    // Add User Value to final position
                    for (int i = 0; i < originalArray.Length;i++)
                    {
                        tempAddArray[i] = originalArray[i];
                    }

                    Console.Write("\nPlease Enter a number: ");
                    int userNum = Convert.ToInt32(Console.ReadLine());

                    tempAddArray[tempAddArray.Length - 1] = userNum;

                    Console.WriteLine("\nNew Array:");
                    Console.Write("\t    ");

                    for (int i = 0; i < tempAddArray.Length; i++)
                    {
                        Console.Write(tempAddArray[i] + " ");
                    }

                    // Over-write original array
                    originalArray = tempAddArray;

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\tError Message: \n\n{0}\n", e);
                }
            }
        }
        else // User get Value == False
        // TODO:
        // Change it to check if get user index is true for alternative sub-functions/user exit option
        {
            // Linear Table Delete
            try
            {
                // Display Array with index numbers
                Console.Write("\n\tIndex:  ");
                for (int i = 0; i < originalArray.Length; i++)
                {
                    Console.Write(i + "  ");
                }
                Console.Write("\n\tValue: ");
                for (int i = 0; i < originalArray.Length; i++)
                {
                    Console.Write(originalArray[i] + " ");
                }

                // Get delete index
                Console.WriteLine("\n\nPlease Enter a zero-indexed location to Delete that number");
                Console.Write("Deletion Index: ");
                int userDeletionIndex = Convert.ToInt32(Console.ReadLine());

                for (int i = 0, x = 0; x < originalArray.Length - 1; i++, x++)
                {
                    if (i == userDeletionIndex)
                    {
                        i++;
                    }

                    tempSubArray[x] = originalArray[i];

                }

                Console.WriteLine("\nNew Array:");
                Console.Write("\t    ");

                for (int i = 0; i < tempSubArray.Length; i++)
                {
                    Console.Write(tempSubArray[i] + " ");
                }

                // Over-write original array
                originalArray = tempSubArray;

            }
            catch (Exception e)
            {
                Console.WriteLine("\n\tError Message: \n\n{0}\n", e);
            }
        }

        
        
        // End of Program Key Hold
        Console.WriteLine("\n\nPress any key to exit");
        Console.ReadKey();
    }
}