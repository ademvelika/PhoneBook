using Persistence.Commands;
using Persistence.Queries;
using PhoneBook.Interface.Commands;
using PhoneBook.Interface.Queries;
using PhoneBook.Interface.UseCase;
using PhoneBook.UseCase;
using PhoneBookCore.Interface;
using PhoneBookCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookValidata
{
    public class PhoneBookInstance:IPhoneBook
    {
        static readonly object _locker = new object();
        IAddUserUseCase _addUseCase;
        IEditUserCase _editUserCase;
        IDeleteUseCase _deleteUseCase;
        IContactQuery _contactQuery;

        public PhoneBookInstance()
        {

            IAddContactCommand cnd = new AddContactCommand();
            IExistContactByNumber exist = new ExistContactByNumber();
            IEditContactCommand editContactCommand = new EditContactCommand();
            IExistByIdQuery existByIdQuery = new ExistByIdQuery();
            IDeleteContactCommand deleteContactCommand   = new DeleteContactCommad();
            _contactQuery = new ContactQuery();

            _addUseCase = new AddUserUseCase(cnd, exist);
            _deleteUseCase = new DeleteUseCase(existByIdQuery, deleteContactCommand);
            _editUserCase = new EditUseCase(existByIdQuery, editContactCommand);

           
        }
        /// <summary>
        /// Add Contact to store
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        public void Add(Contact c)
        {
            lock (_locker)
            {
                _addUseCase.Handle(c);
            }
        }
        /// <summary>
        /// Edit Contact to store
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        public void Delete(Contact c)
        {
            lock (_locker)
            {
                _deleteUseCase.Handle(c);
            }
        }

        /// <summary>
        /// Edit Contact to store
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        public void Edit(Contact c)
        {
            lock(_locker)
            {
                _editUserCase.Handle(c);
            }
            
        }

        /// <summary>
        /// Enumerate Contact by alphabet
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        public IEnumerable<Contact> GetConcactOrderByAlphabet()
        {
         return   _contactQuery.Execute().OrderBy(x => x.Name).OrderBy(x=>x.SurName).ToList();
        }
        /// <summary>
        /// Enumerate Contact by first name
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        public IEnumerable<Contact> GetConcactOrderByFirstName()
        {
            return _contactQuery.Execute().OrderBy(x => x.Name).ToList();
        }

        /// <summary>
        /// Enumerate Contact by last name
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        public IEnumerable<Contact> GetConcactOrderByLastName()
        {
            return _contactQuery.Execute().OrderBy(x => x.SurName).ToList();
        }
    }
}
