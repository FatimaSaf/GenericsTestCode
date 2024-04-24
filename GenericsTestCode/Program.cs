namespace GenericsTestCode
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            ValTypeCont<int> ContainerInt = new ValTypeCont<int>();

           
            ContainerInt.AddItem(15);
            ContainerInt.AddItem(10);
            ContainerInt.AddItem(30);

            
            Console.WriteLine("index 1: " + ContainerInt.GetItem(1));

            
            var SortedListForInt = ContainerInt.SortInDescinding();
            Console.WriteLine("Sorted list  for Int in descending order:");
            foreach (var item in SortedListForInt)
            {
                Console.WriteLine(item);
            }

            ValTypeCont<double> ContainerDouble = new ValTypeCont<double>();

           
            ContainerDouble.AddItem(4.55);
            ContainerDouble.AddItem(3.99);
            ContainerDouble.AddItem(1.618);

           
            Console.WriteLine("index 2: " + ContainerDouble.GetItem(2));

            var SortedListForDouble = ContainerDouble.SortInDescinding();
            Console.WriteLine("Sorted List For Double in descending order:");
            foreach (var item in SortedListForDouble)
            {
                Console.WriteLine(item);
            }
        }
    }
}
