using System;
namespace ADO.NETAddressBook
{
    class program
    {
        public static void Main(string[] args)
        {
            BookAnalyser exp = new BookAnalyser();
            exp.getDataFromAddressBook();
        }
    }
}
