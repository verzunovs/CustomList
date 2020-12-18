namespace MyList
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Insert(0, 2);
            list.Remove(1);
        }
    }
}
