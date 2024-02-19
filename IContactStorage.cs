namespace ContactManagementSystem
{
    public interface IContactStorage
    {
        List<Contact> LoadContacts();

        void SaveContacts(List<ContactManagementSystem>contacts);
    }
}
