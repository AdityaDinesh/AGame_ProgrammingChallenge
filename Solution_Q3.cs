// Note : Naming Convention used in the following code
//
//        1) Variables having a prefix 'a' are local variables
//        2) Varaibles having a prefix 'p' are parameter varaibles

class Solution_Q3
{
    // Finds and returns the total number of cars passing each other
    private static int Solution(int[] pA)
    {
        int aEastCars = 0;          // Count eastbound cars
        int aPassingCars = 0;       // Count cars passing each other

        foreach (var aDir in pA)
        {
            // Add eastbound car's count when its encountered
            if(aDir == 0)
            {
                aEastCars++;
            }

            // Based on total eastbound cars encountered, add passing car's count when a westbound car is encountered
            else
            {
                aPassingCars += aEastCars;
                if(aPassingCars > 1000000000)    
                {
                    return -1; 
                }
            }
        }
        return aPassingCars;
    }

    private static void Main(string[] args)
    {
        // Read Values from User
        Console.WriteLine("Enter total number of integers in the array : ");
        int aN = Convert.ToInt32(Console.ReadLine());
        int[] aA = new int[aN];
        Console.WriteLine("Enter the integers for the array : ");
        for (int aI = 0; aI < aN; aI++)
        {
            aA[aI] = Convert.ToInt32(Console.ReadLine());
        }

        int aTotalPassingCars = Solution(aA);
        Console.WriteLine("Total number of passing cars is " + aTotalPassingCars);
    }
}