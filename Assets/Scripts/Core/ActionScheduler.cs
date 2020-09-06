namespace Core
{
    public class ActionScheduler
    {
        private IAction _currentAction;

        public void ExecuteAction(IAction action)
        {
            _currentAction?.Cancel();
            action.Execute();
            _currentAction = action;
        }
    }
}