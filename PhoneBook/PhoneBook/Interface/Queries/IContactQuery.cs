using PhoneBookCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Interface.Queries
{
   public interface IContactQuery
    {
        IEnumerable<Contact> Execute();
    }
}
