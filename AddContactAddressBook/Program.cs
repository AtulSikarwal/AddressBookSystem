namespace AddressBookSystem
{
     class Program
    {
        public static void Main(String[]args)
        {
            string Commit = " ";
            Console.WriteLine("Welcome To Address Book ");


            while (Commit != "Exit")
            {
               // Console.Clear();
                Console.WriteLine("1 for Add Contacts");
               
               
                int Opition = Convert.ToInt32(Console.ReadLine());

                switch (Opition)
                {
                    case 1:
                        AddressBook Address = new AddressBook();
                        Address.AddPerson();
                        break;
                    
                   
                    default:
                        Console.WriteLine("Enter Vaild Input");
                        Commit = "Exit";
                        break;
                }
            }
        }
    }
}