using PhoneBookCore.Interface;
using PhoneBookCore.Model;
using PhoneBookValidata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactConsole
{
    class Program
    {
        static void Main(string[] args)
        {

          IPhoneBook  book = new PhoneBookInstance();

            Contact c = new Contact
            {
                Name = "geri",
                Number = "0695614904",
                SurName = "lin",
                Type = "Home"
            };
            book.Add(c);
            Console.WriteLine("=============================");
            Console.WriteLine("After add one record");
            Console.WriteLine("=============================");
            ShoWContacts(book.GetConcactOrderByAlphabet());

            Contact c1 = new Contact
            {
                Name = "adem",
                Number = "0695614905",
                SurName = "velika",
                Type = "Home"
            };

            book.Add(c1);
            Console.WriteLine("=============================");
            Console.WriteLine("After add two records");
            Console.WriteLine("=============================");
            var records = book.GetConcactOrderByAlphabet();
          

      
          

            ShoWContacts(records);
            Console.WriteLine("=============================");
            Console.WriteLine("Delete first record in list");
            Console.WriteLine("=============================");

            book.Delete(records.FirstOrDefault());
            records = book.GetConcactOrderByAlphabet();
            ShoWContacts(records);
            Console.WriteLine("=============================");
            Console.WriteLine("Edit first record in list");
            Console.WriteLine("=============================");
            records.FirstOrDefault().Name = "Edited";
            book.Edit(records.FirstOrDefault());
            ShoWContacts(book.GetConcactOrderByAlphabet());

            Console.ReadLine();


        }

        static void ShoWContacts(IEnumerable<Contact> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
