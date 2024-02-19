namespace ContactManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize new FileContactStorage and ContactBook.


            // Implement user interaction loop here:
            // Display menu options, take user input, and call corresponding ContactBook methods
            while (true)
            {
                Console.WriteLine("\nContact Book Application");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. View Contacts");
                Console.WriteLine("3. Update Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        // Add contact flow
                        break;
                    case "2":
                        // View contacts flow
                        break;
                    case "3":
                        // Update contact flow
                        break;
                    case "4":
                        // Delete contact flow
                        break;
                    case "5":
                        // Exit application
                        Console.WriteLine("Exiting application...");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }

}