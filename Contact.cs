namespace ContactManagementSystem
{
    public class Contact
    {
        public int Id{ get; set; };
        public string Name{ get; set; };
        public string Email{ get; set; };
        public long int PhoneNumber{ get; set; };

        public Contact(int id, string name, string email, long int phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }


    }
}