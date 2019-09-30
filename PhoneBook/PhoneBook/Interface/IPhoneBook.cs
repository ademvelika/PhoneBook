using PhoneBookCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCore.Interface
{
   public interface IPhoneBook
    {
        /// <summary>
        /// Add Contact to store
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        void Add(Contact c);
        /// <summary>
        /// Edit Contact to store
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        void Delete(Contact c);
        /// <summary>
        /// Edit Contact to store
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        void Edit(Contact c);

        /// <summary>
        /// Enumerate Contact by alphabet
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        IEnumerable<Contact> GetConcactOrderByAlphabet();

        /// <summary>
        /// Enumerate Contact by First Name
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        IEnumerable<Contact> GetConcactOrderByFirstName();

        /// <summary>
        /// Enumerate Contact by Last Name
        /// Exception throws if error occured
        /// </summary>
        /// <param name="c"></param>
        IEnumerable<Contact> GetConcactOrderByLastName();

    }
}
