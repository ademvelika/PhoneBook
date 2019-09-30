using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class FileData
    {

        public static string fileName = AppDomain.CurrentDomain.BaseDirectory+ ConfigurationManager.AppSettings["PhoneBookPersistenceFilePath"];
    }
}
