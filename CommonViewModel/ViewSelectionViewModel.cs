using System.Windows.Forms;

namespace CommonViewModel
{
    public class ViewSelectionViewModel : ViewModelBase
    {
        public ViewSelectionViewModel()
        {
            ViewSelectionCommand = new ComplexCommand(OnViewSelectionRequested, OnChanged);
        }

        public ComplexCommand ViewSelectionCommand { get; set; }

        private bool OnChanged(object obj)
        {
            return true;
        }

        private void OnViewSelectionRequested(object viewName)
        {
            MessageBox.Show(viewName.ToString());
        }
    }
}