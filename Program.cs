namespace LinkedListAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //-----------------LINKED LIST-------------------------------
            LinkedList list = new LinkedList();
            list.Add(56);
            // list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("");
            Console.WriteLine("Enter 1 for insert node, \n" +
                               "Enter 2 for delete node at first, \n" +
                               "Enter 3 for add node at particular position, \n" +
                               "Enter 4 for delete node at last, \n" +
                               "Enter 5 for search node in list, \n" +
                               "Enter 6 for delete node at particuar position,\n" +
                               "Enter 7 for show List, \n" +
                               "Enter 8 for see Sorted List.\n");
            list.InsertAtParticularPosition(2, 30);
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    list.InsertAtParticularPosition(3, 40);
                    Console.WriteLine("The list after updation:");
                    list.Display();
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("The list after Delete first Node:");
                    list.Pop();
                    list.Display();
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Enter the position: ");
                    int postion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Data : ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    list.InsertAtParticularPosition(postion, data);
                    Console.WriteLine("After insert Node again now List again look like: ");
                    list.Display();
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.WriteLine("The list after Delete Last Node:");
                    list.PopLast();
                    list.Display();
                    Console.WriteLine("");
                    break;
                case 5:
                    int post = list.Search(30);
                    Console.WriteLine("Node 30 on position: " + post);
                    break;
                case 6:
                    list.DeleteNodeAtParticularPosition(1);
                    break;
                case 7:
                    list.Display();
                    Console.WriteLine("");
                    break;
                case 8:
                    list.Sortedlist();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;


            }

        }

    }
}
