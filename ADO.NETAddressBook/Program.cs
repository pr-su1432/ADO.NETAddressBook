using System;
namespace ADO.NETAddressBook
{
    class program
    {
        public static void Main(string[] args)
        {
            BookAnalyser count = new BookAnalyser();
            // count.getDataFromAddressBook();
            //count.UpdateDetails();
            //count.DeleteDetails();
            //count.CreateNewContactDetails();
            List<Book> list = new List<Book>();
            Console.WriteLine("Enter number of contacts to Add");
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < number)
            {
                ADO.NETAddressBook.Book exp = new ADO.NETAddressBook.Book();

                Console.WriteLine("Enter First Name");
                exp.FIRSTNAME = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                exp.LASTNAME = Console.ReadLine();
                Console.WriteLine("Enter Address ");
                exp.ADDRESSs = Console.ReadLine();
                Console.WriteLine("Enter City ");
                exp.CITY = Console.ReadLine();
                Console.WriteLine("Enter State ");
                exp.STATE = Console.ReadLine();
                Console.WriteLine("Enter Zip Code ");
                exp.ZIP = Console.ReadLine();
                Console.WriteLine("Enter Phone ");
                exp.PHONENO = Console.ReadLine();
                Console.WriteLine("Enter Email ");
                exp.EMAIL = Console.ReadLine();
                list.Add(exp);
                i++;
            }
           count.AddMultipleEmployee(list);
        }
    }
}
