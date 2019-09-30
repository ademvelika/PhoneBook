using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookCore.Model
{
  public  class Contact
    {
        /// <summary>
        /// Unique Identifier
        /// </summary>
        public string Guid { get; set; }

        /// <summary>
        /// Name of user
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname of User
        /// </summary>
        public string SurName { get; set; }
        /// <summary>
        /// Type of numer Work,Cellphone,or Home
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Numer as string characters
        /// </summary>
        public string Number { get; set; }

        public override string ToString()
        {
            return $"{Name}  {SurName}  {Type} {Number}";
        }
    }
}
