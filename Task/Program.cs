namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Return Numbers whose position is match their value int[]
            int[] Arr = { 3, 4, 2, 0, 1, 5, 6 };

            var result = Arr.Where((number, index) => number == index);

            foreach (var item in result)
            {
                Console.WriteLine(item); //2, 5, 6
            }
        }
    }
}
