using System.Windows.Input;

namespace CommonViewModel
{
    public class SaveUpdateViewModel : ViewModelBase
    {
        public SaveUpdateViewModel()
        {
            SaveCommand = new SimpleCommand(OnSaved, o => true);
            ClearCommand = new SimpleCommand(OnClear, o => true);
        }

        public ICommand SaveCommand { get; set; }
        public ICommand ClearCommand { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }

        private void ClearAllFields()
        {
            Name = Address = Email = Gender = MobileNumber = string.Empty;
            OnPropertyChanged("Name");
            OnPropertyChanged("Address");
            OnPropertyChanged("Email");
            OnPropertyChanged("Gender");
            OnPropertyChanged("MobileNumber");
        }

        private void OnClear()
        {
            ClearAllFields();
        }

        private void OnSaved()
        {
            // Code for Save Data
        }
    }
}