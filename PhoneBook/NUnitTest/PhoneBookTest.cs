using NUnit.Framework;
using PhoneBookCore.Interface;
using PhoneBookCore.Model;
using PhoneBookValidata;

namespace NUnitTest
{
    [TestFixture]
    public class PhoneBookTest
    {
        IPhoneBook book;

       [SetUp]
        public void Init()
        {
         
                
                
                book= new PhoneBookInstance();
        }
        
        [Test]
        public void AddContact()
        {       
            Contact c = new Contact
            {
                Name = "tes15",
                Number = "0695614904",
                SurName = "test5",
                Type = "Home"
            };

            Assert.DoesNotThrow(() => book.Add(c)); 
        }

        [Test]
        public void GetContactsByAlphabet()
        {
            Assert.DoesNotThrow(() => book.GetConcactOrderByAlphabet());
        }

        [Test]
        public void EditContact()
        {

           
            Contact c = new Contact
            {
                Guid= "c47bb08e-4e07-428a-81ef-95cfae3e94b6",
                Name = "testedit",
                Number = "0695614904",
                SurName = "testedit",
                Type = "Home"
            };
            Assert.DoesNotThrow(() => book.Edit(c));
        }

        [Test]
        public void DeleteContact()
        {

           
            Contact c = new Contact
            {
                Guid = "c47bb08e-4e07-428a-81ef-95cfae3e94b6",
                Name = "testedit",
                Number = "0695614904",
                SurName = "testedit",
                Type = "Home"
            };

            Assert.DoesNotThrow(() => book.Delete(c));


        }

    }
}
