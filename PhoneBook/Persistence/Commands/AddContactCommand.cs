using PhoneBook.Interface.Commands;
using PhoneBookCore.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Commands
{
    public class AddContactCommand : IAddContactCommand
    {
        public void Execute(Contact param)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(FileData.fileName, FileMode.Append)))
            {
                writer.Write(Guid.NewGuid().ToString());
                writer.Write(param.Name);
                writer.Write(param.SurName);
                writer.Write(param.Type);
                writer.Write(param.Number);
            }
        }
    }
}
