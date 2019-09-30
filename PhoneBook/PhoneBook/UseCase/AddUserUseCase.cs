using PhoneBook.Interface.Commands;
using PhoneBook.Interface.Queries;
using PhoneBook.Interface.UseCase;
using PhoneBookCore.Model;
using System;

namespace PhoneBook.UseCase
{
   
    public class AddUserUseCase : IAddUserUseCase
    {
        readonly IAddContactCommand _addContactCommand;
        readonly IExistContactByNumber _existContactByNumber;

        public AddUserUseCase(IAddContactCommand addContactCommand, IExistContactByNumber existContactByNumber)
        {
            _addContactCommand = addContactCommand;
            _existContactByNumber = existContactByNumber;
        }
        public void Handle(Contact c)
        {
            if (_existContactByNumber.Execute(c))
            {
                throw new Exception("User with this number exists");
            }
            _addContactCommand.Execute(c);
        }
    }
}
