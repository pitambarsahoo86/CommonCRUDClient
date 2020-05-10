using System;
using System.Windows.Input;

namespace CommonViewModel
{
    public class ComplexCommand : ICommand
    {
        private readonly Action<object> myAction;
        private readonly Predicate<object> myCanExecute;

        public ComplexCommand(Action<object> action, Predicate<object> canExecute)
        {
            myAction = action;
            myCanExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (myCanExecute == null)
                return false;

            return myCanExecute.Invoke(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (myAction != null)
            {
                myAction.Invoke(parameter);
            }
        }
    }
}