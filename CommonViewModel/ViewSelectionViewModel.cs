namespace CommonViewModel
{
    public class ViewSelectionViewModel : ViewModelBase
    {
        public ViewSelectionViewModel()
        {
            SaveUpdateViewModel = new SaveUpdateViewModel();

            // Subscribe event.
            EventCommunicator.EventInstance.EventAggregator.GetEvent<ViewSelectionEvent>().Subscribe(OnViewSelected);
        }

        public bool IsCreateTabSelected { get; set; }
        public bool IsReadTabSelected { get; set; }
        public bool IsDeleteTabSelected { get; set; }
        public string HeaderName { get; set; }
        public SaveUpdateViewModel SaveUpdateViewModel { get; set; }

        private void OnViewSelected(object viewName)
        {
            IsCreateTabSelected = viewName.ToString().Equals("Create") || viewName.ToString().Equals("Update");
            IsReadTabSelected = viewName.ToString().Equals("Read");
            IsDeleteTabSelected = viewName.ToString().Equals("Delete");
            HeaderName = viewName.ToString().Equals("Create") ? "Save" : "Update";

            OnPropertyChanged("IsCreateTabSelected");
            OnPropertyChanged("IsReadTabSelected");
            OnPropertyChanged("IsDeleteTabSelected");
            OnPropertyChanged("HeaderName");
        }
    }
}