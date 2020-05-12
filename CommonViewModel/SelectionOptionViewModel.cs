namespace CommonViewModel
{
    public class SelectionOptionViewModel : ViewModelBase
    {
        public SelectionOptionViewModel()
        {
            ViewSelectionCommand = new ComplexCommand(OnOptionSelected, canExecute=>true);
        }

        public ComplexCommand ViewSelectionCommand { get; set; }

        private void OnOptionSelected(object viewName)
        {
            // Publish event.
            EventCommunicator.EventInstance.EventAggregator.GetEvent<ViewSelectionEvent>().Publish(viewName.ToString());
        }
    }
}