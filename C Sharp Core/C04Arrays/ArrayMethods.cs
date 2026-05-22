namespace C_Sharp_Core.C04Arrays
{
    internal class ArrayMethods
    {
        public static void Main()
        {
            int[] arr1 = { 5, 1, 4, 7, 2, 6, 3 };

            //Sort Array
            Array.Sort(arr1);
            Console.WriteLine( string.Join(", ", arr1)) ; // 1 2 3 4 5 6 7

            //Reverse Array
            Array.Reverse(arr1);
            Console.WriteLine(string.Join(", ", arr1)); // 7, 6, 5, 4, 3, 2, 1

            // Find index
            Console.WriteLine( Array.IndexOf(arr1, 5) ) ; // 2

            // Check element that matches condition
            Console.WriteLine( Array.Exists(arr1, e => e%5==0) ) ; // true

            // Compare 2 arrays
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 1, 2, 3, 4 };
            int[] nums3 = { 4, 3, 2, 1 };
            Console.WriteLine( Array.Equals(nums1, nums2) ); // False -> Compares Reference


            Console.WriteLine( nums1.SequenceEqual(nums2) ) ; // True -> compars elements
            Console.WriteLine( nums1.SequenceEqual(nums3) ) ; // False -> compars elements, still false because elements order difference


        }
    }
}
