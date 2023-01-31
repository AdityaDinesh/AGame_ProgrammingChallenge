// Note : Naming Convention used in the following code
//
//        1) Variables having a prefix 'a' are local variables
//        2) Varaibles having a prefix 'p' are parameter varaibles

class Solution_Q1
{
    // Finds and returns the smallest positive integer not present in the given array
    private static int Solution(int[] pA)
    {
        // Transfer array data to hashset to remove duplication and accessing values faster
        int aN = pA.Length;
        HashSet<int> aSet = new HashSet<int>();
        foreach (int aVar in pA)
        {
            if (aVar > 0)
            {
                aSet.Add(aVar);
            }
        }

        // Checks for the smallest positive integer and returns it. 
        for (int aI = 1; aI <= aN + 1; aI++)
        {
            if (!aSet.Contains(aI))
            {
                return aI;
            }
        }
        return 1;              
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

        int aSmallPosInt = Solution(aA);
        Console.WriteLine("The smallest positive integer, not present in the array is " + aSmallPosInt);
    }
}
