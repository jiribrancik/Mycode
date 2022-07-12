
namespace UniqueNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[,]
            {
                { 1, 1 },
                { 4, 2 },
            };
            GetUniqueNumbers(arr1);

            int[,] arr2 = new int[,]
            {
                { 4, 3, -1 },
                { 10, 2, 5 },
                { -2, 3, 4 },
            };
            GetUniqueNumbers(arr2);
        }
        static List<int> GetUniqueNumbers(int[,] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (list.Contains(arr[i, j]))
                    {
                    }
                    else
                    {
                        list.Add(arr[i, j]);
                    }
                }
            }
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            return list;
        }
    }
}