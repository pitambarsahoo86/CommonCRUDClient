using System.ComponentModel;

namespace CommonViewModel
{
    public class ViewModelBase : INotifyPropertyChanged, INotifyPropertyChanging
    {
        protected ViewModelBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void OnPropertyChanging(string propertyName)
        {
            PropertyChangingEventHandler propertyChanging = PropertyChanging;
            if (propertyChanging != null)
            {
                propertyChanging.Invoke(this, new PropertyChangingEventArgs(propertyName));
            }
        }
    }
}