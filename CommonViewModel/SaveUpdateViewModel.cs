using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;

namespace CommonViewModel
{
    public class SaveUpdateViewModel : ViewModelBase
    {
        public SaveUpdateViewModel()
        {
            SaveCommand = new SimpleCommand(OnSaved, o => true);
            //SaveCommand = new DelegateCommand(OnSaved);
            ClearCommand = new SimpleCommand(OnClear, o => true);
        }

        public ICommand SaveCommand { get; set; }

        public ICommand ClearCommand { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }

        private void OnClear()
        {
        }

        private void OnSaved()
        {
        }
    }
}