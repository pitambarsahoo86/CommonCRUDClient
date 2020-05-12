namespace CommonViewModel
{
    public class SearchViewModel : ViewModelBase
    {
        public SearchViewModel()
        {
            SearchOptionCommand = new ComplexCommand(OnSearchOptionSelected, canExecute => true);
        }

        public ComplexCommand SearchOptionCommand { get; set; }

        private void OnSearchOptionSelected(object viewName)
        {
            NameGroupVisibility = viewName.Equals("Name");
            IdGroupVisibility = viewName.Equals("Id");

            OnPropertyChanged("NameGroupVisibility");
            OnPropertyChanged("IdGroupVisibility");
        }

        public bool NameGroupVisibility { get; set; }
        public bool IdGroupVisibility { get; set; }
}
}