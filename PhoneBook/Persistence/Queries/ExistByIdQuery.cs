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
    public class ExistByIdQuery : IExistByIdQuery
    {
        public bool Execute(Contact c)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(FileData.fileName, FileMode.OpenOrCreate)))
            {
                var list = new List<Contact>();
                int pos = 0;
                bool Exist = false;
                int length = (int)reader.BaseStream.Length;
                while (pos < length)
                {
                    var record = new Contact
                    {
                        Guid = reader.ReadString(),
                        Name = reader.ReadString(),
                        SurName = reader.ReadString(),
                        Type = reader.ReadString(),
                        Number = reader.ReadString()

                    };
                    if (record.Guid == c.Guid)
                    {
                        Exist = true;
                        break;
                    }

                    pos += System.Text.ASCIIEncoding.Unicode.GetByteCount(record.Guid + record.Name + record.SurName + record.Type + record.Number);
                }
                return Exist;
            }
        }
    }
}
