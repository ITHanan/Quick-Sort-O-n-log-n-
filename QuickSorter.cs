namespace Quick_Sort___O_n_log_n_
{
    internal class QuickSorter
    {
        public static void QuickSort(int[] array, int left, int roght) 
        {
            if (left < roght) 
            {
                // find the pivot element such that element smolar then pivot are on the left of pivot and greater on the right 
                int pivotIndex = Partition(array, left, roght);

                // Continuoaly sort the left and right subarrays 
                QuickSort(array, left, pivotIndex - 1);

                QuickSort(array, pivotIndex + 1, roght);

            }
        
        }

        public static int Partition(int[] array, int left, int right) 
        {
            int povit = array[right]; // taking the last element as pivot 
            int i = left - 1; // pointer for the smaller element 

            for (int j = left; j < right; j++) 
            {
                // if the current element id smaller then or = to pivot 
                if (array[j] <= povit) 
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);

                }
            
            }

            // Swap the pivot element with array[i+1]
            (array[i + 1], array[right])= (array[right], array[i + 1]);

            return i + 1 ;

        }

        public static bool BinarSerch(int[] array, int target)
        
        {
            int left = 0, right = array.Length - 1;

            while (left <= right) 
            {
             int middleIndex = left + (right - left) / 2;

                if (array[middleIndex] == target) // If the middle element (arr[mitten]) is equal to mål, we have found the target and return true.
                    return true;



                // If the middle element is less than mål, then the target must be on the right side of the array, so we update vänster = mitten + 1.
                if (array[middleIndex] < target)
                    left = middleIndex + 1 ;

                // Otherwise, if the middle element is greater than mål, then the target must be on the left side, so we update höger = mitten - 1.

                else right = middleIndex - 1 ;
            }

            return false;
        }
    }
}
