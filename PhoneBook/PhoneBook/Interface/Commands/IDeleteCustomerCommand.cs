using PhoneBookCore.Model;

namespace PhoneBook.Interface.Commands
{
 public   interface IDeleteContactCommand
    {

        void Execute(Contact c);
    }
}
