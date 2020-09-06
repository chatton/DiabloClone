namespace Core
{
    public interface IAction
    {
        void Execute();
        void Cancel();
    }
}