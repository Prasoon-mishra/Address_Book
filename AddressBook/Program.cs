namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book!!!!");
            ////UC1 Create Contact
            AddressBook addressBook = new AddressBook("Prasoon", "Mishra", "Near xyz", "Kanpur", "UP", 415896, 2004155615, "Prasu@gamil.com");
            addressBook.display();
        }
    }
}