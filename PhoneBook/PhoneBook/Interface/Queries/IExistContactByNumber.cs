using PhoneBookCore.Model;

namespace PhoneBook.Interface.Queries
{
    public interface IExistContactByNumber
    {
       bool Execute(Contact c);

    }
}
