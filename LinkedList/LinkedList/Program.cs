namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList();
            l1.InsertFirst(20);
            l1.InsertFirst(30);
            
            l1.InsertLast(34);
            l1.Insert(200, 1);
            l1.Display();
        }
    }
}
