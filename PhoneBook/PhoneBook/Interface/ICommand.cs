namespace PhoneBookCore.Interface
{
    public interface ICommand<TIn>
    {
        void Execute(TIn param);
    }
}
