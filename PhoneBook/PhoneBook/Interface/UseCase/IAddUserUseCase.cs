using PhoneBookCore.Model;

namespace PhoneBook.Interface.UseCase
{
    public interface IAddUserUseCase
    {

        void Handle(Contact c);
    }
}
