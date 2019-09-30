using PhoneBook.Interface.Commands;
using PhoneBookCore.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Persistence.Commands
{
    public class EditContactCommand : IEditContactCommand
    {
        public void Execute(Contact param)
        {
            var list = new List<Contact>();
            //read all record
            using (BinaryReader reader = new BinaryReader(File.Open(FileData.fileName, FileMode.Open)))
            {
              
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
                    list.Add(record);
                    pos += System.Text.ASCIIEncoding.Unicode.GetByteCount(record.Guid + record.Name + record.SurName + record.Type + record.Number);
                }
               
            }

            var tempfile = AppDomain.CurrentDomain.BaseDirectory + "temp.dat";
            //write in temp file
            using (BinaryWriter writer = new BinaryWriter(File.Open(tempfile, FileMode.Append)))
            {
                foreach (var item in list)
                {
                    if (item.Guid == param.Guid)
                    {
                        writer.Write(param.Guid);
                        writer.Write(param.Name);
                        writer.Write(param.SurName);
                        writer.Write(param.Type);
                        writer.Write(param.Number);
                    }
                    else
                    {
                        writer.Write(item.Guid);
                        writer.Write(item.Name);
                        writer.Write(item.SurName);
                        writer.Write(item.Type);
                        writer.Write(item.Number);
                    }
                }
            }

            //delete original
            File.Delete(FileData.fileName);
            //copy ne file to current path
            File.Move(tempfile, FileData.fileName);

        }
    }
}
