using System;

namespace simpleAPP
{
    class Program
    {
        struct Books 
        {
            public string title;
            public string author;
            public string subject;
            public int book_id;
        };
        struct multiplication
        {
            public int numberA;
            public int numberB;
            public int result;
        }
    static void Main(string[] args)
    {
        Books[] BookArray = new Books[4];
        multiplication[] mathArray = new multiplication[4];
        int Order = 1;
        int math = 1;
        bool endApp = false;

        while (!endApp)
            {
            Console.WriteLine("Book Store\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Choose an operation :");
            Console.WriteLine("\ta - Add book");
            Console.WriteLine("\tl - List of book");
            Console.WriteLine("\tm - multiply");
            Console.Write("Your option? ");

            string op = Console.ReadLine();

            switch(op)
            {
                case "a":
                        Console.WriteLine("Please enter title");
                        BookArray[Order].title= Console.ReadLine();
                        Console.WriteLine("Please enter author");
                        BookArray[Order].author = Console.ReadLine();
                        Console.WriteLine("Please enter subject");
                        BookArray[Order].subject = Console.ReadLine();
                        Console.WriteLine("Please enter book id");
                        BookArray[Order].book_id = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Order +=1;
                        break;
                case "l":
                        Console.WriteLine(new string('=', 20));
                        Console.WriteLine("Book list");
                        for(int i = 1;i < Order;i++)
                        {
                            Console.WriteLine(new string('=', 20));
                            Console.WriteLine("Book number" + i);
                            Console.WriteLine("Book author :{0}",BookArray[i].author);
                            Console.WriteLine("Book title :{0}",BookArray[i].title);
                            Console.WriteLine("Book subject :{0}",BookArray[i].subject);
                            Console.WriteLine("Book id :{0}",BookArray[i].book_id);
                        }
                        break;
                case "m":
                        int a = multiply(math);
                        Console.WriteLine(a);
                        break;
                default:
                        break;
            }


            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n"); // Friendly linespacing.
            }
        return;
        }
        public static int multiply(int math)
        {
            Console.WriteLine("enter number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number ");
            int b = int.Parse(Console.ReadLine());
            return a + b;
        }
    }
}
