using PhoneBook.Interface.Commands;
using PhoneBook.Interface.Queries;
using PhoneBook.Interface.UseCase;
using PhoneBookCore.Model;
using System;


namespace PhoneBook.UseCase
{
    public class EditUseCase : IEditUserCase
    {

        readonly IExistByIdQuery _existByIdQuery;
        readonly IEditContactCommand _editContactCommand;

        public EditUseCase(IExistByIdQuery existByIdQuery,IEditContactCommand editContactCommand)
        {
            _existByIdQuery = existByIdQuery;
            _editContactCommand = editContactCommand;
        }
        public void Handle(Contact c)
        {
            if (!_existByIdQuery.Execute(c))
            {
                throw new Exception("User with this id not found");
            }
            _editContactCommand.Execute(c);
        }
    }
}
