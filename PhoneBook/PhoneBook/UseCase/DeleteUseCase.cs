using PhoneBook.Interface.Commands;
using PhoneBook.Interface.Queries;
using PhoneBook.Interface.UseCase;
using PhoneBookCore.Model;
using System;
namespace PhoneBook.UseCase
{
  public  class DeleteUseCase:IDeleteUseCase
    {

        readonly IExistByIdQuery _existByIdQuery;
        readonly IDeleteContactCommand _deleteCustomerCommand;

        public DeleteUseCase(IExistByIdQuery existByIdQuery,IDeleteContactCommand deleteCustomerCommand)
        {
            _existByIdQuery = existByIdQuery;
            _deleteCustomerCommand = deleteCustomerCommand;
        }
        public void Handle(Contact c)
        {
            if (!_existByIdQuery.Execute(c))
            {
                throw new Exception("User with this id not found");
            }
            _deleteCustomerCommand.Execute(c);
        }

        
    }
}
