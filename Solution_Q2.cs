// Note : Naming Convention used in the following code
//
//        1) Variables having a prefix 'a' are local variables
//        2) Varaibles having a prefix 'p' are parameter varaibles

class Solution_Q2
{
    // Finds and returns the shortest time in which the frog crosses the river
    private static int Solution(int pX, int[] pA)
    {
        int aSteps = pX;
        bool[] aBitmap = new bool[aSteps + 1]; // Using a boolean array to check if a leaf has fallen on the river step

        // Iterate through the array and mark the corresponding step if its empty. When a step is marked decrement
        // the total steps by one. When total steps is zero return the array index (i.e Time).
        for (int i = 0; i < pA.Length; i++)
        {
            if (!aBitmap[pA[i]])
            {
                aBitmap[pA[i]] = true;
                aSteps--;
                if (aSteps == 0) return i;
            }
        }
        return -1;              // Returns -1 when all steps are not marked (i.e frog cannot cross river) 
    }

    private static void Main(string[] args)
    {
        // Read Values from User
        Console.WriteLine("Enter total number of steps : ");
        int aX = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter size of Array : ");
        int aN = Convert.ToInt32(Console.ReadLine());
        int[] aA = new int[aN];
        Console.WriteLine("Enter the integers for the array : ");
        for (int aI = 0; aI < aN; aI++)
        {
            aA[aI] = Convert.ToInt32(Console.ReadLine());
        }

        int aTime = Solution(aX, aA);
        Console.WriteLine("The earliest time the frog can cross is " + aTime);
    }
}