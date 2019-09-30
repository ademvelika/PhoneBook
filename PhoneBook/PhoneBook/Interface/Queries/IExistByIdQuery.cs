using PhoneBookCore.Model;

namespace PhoneBook.Interface.Queries
{
    public  interface IExistByIdQuery
    {
        bool Execute(Contact c);
    }
}
