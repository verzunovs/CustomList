namespace MyList
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("A");
            list.Add("bbc");
            list.Add("nk");
            list.Add("abc");
            list.Insert(2, "ab");
            list.RemoveAt(1);
            System.Collections.Generic.List<int> list2 = new System.Collections.Generic.List<int>();
            list2.Add(1);
            list2.IndexOf(1);
        }
    }
}
