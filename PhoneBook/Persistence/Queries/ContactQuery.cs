using PhoneBook.Interface.Queries;
using PhoneBookCore.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Queries
{
    public class ContactQuery : IContactQuery
    {
        public IEnumerable<Contact> Execute()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(FileData.fileName, FileMode.Open)))
            {
                var list = new List<Contact>();
                int pos = 0;
              
                int length = (int)reader.BaseStream.Length;
                while (pos < length)
                {
                    var c = new Contact
                    {
                        Guid = reader.ReadString(),
                        Name = reader.ReadString(),
                        SurName = reader.ReadString(),
                        Type = reader.ReadString(),
                        Number = reader.ReadString()

                    };
                    
                    list.Add(c) ; 
                    pos += System.Text.ASCIIEncoding.Unicode.GetByteCount(c.Guid+c.Name+c.SurName+c.Type+c.Number);
                }
                return list;
            }
        }
    }
}
