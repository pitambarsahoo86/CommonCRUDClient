namespace CommonViewModel
{
    public class SelectionOptionViewModel : ViewModelBase
    {
        public SelectionOptionViewModel()
        {
            ViewSelectionCommand = new ComplexCommand(OnOptionSelected, OnChanged);
        }

        public ComplexCommand ViewSelectionCommand { get; set; }

        private bool OnChanged(object obj)
        {
            return true;
        }

        private void OnOptionSelected(object viewName)
        {
            // Publish event.
            EventCommunicator.EventInstance.EventAggregator.GetEvent<ViewSelectionEvent>().Publish(viewName.ToString());
        }
    }
}