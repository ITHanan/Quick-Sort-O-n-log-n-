namespace Quick_Sort___O_n_log_n_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 33, 10, 55, 2, 19, 20 };
            int[] array02 = { 2, 5, 8, 12, 16, 23, 38, 45, 57, 79 };

            Console.WriteLine("Original array: " + string.Join(", ", array));

            QuickSorter.QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("\nSorted array " + string.Join(", ", array));

            Console.WriteLine();


            int middleIndex01 = 38;

            int middleIndex02 = 15;

            Console.WriteLine("searching for  " + middleIndex01 + " in the array ...");
            bool resultat1 = QuickSorter.BinarSerch(array02, middleIndex01);
            Console.WriteLine("found " + middleIndex01 + "? " + (resultat1 ? "Yes" : "No"));


            Console.WriteLine("searching for  " + middleIndex02 + " in the array ...");
            bool resultat102 = QuickSorter.BinarSerch(array02, middleIndex02);
            Console.WriteLine("found " + middleIndex02 + "? " + (resultat102 ? "Yes" : "No"));


        }

       
        
    }
}
