using Microsoft.Practices.Composite.Events;

namespace CommonViewModel
{
    public sealed class EventCommunicator
    {
        private static readonly EventCommunicator LocalEventInstance = new EventCommunicator();
        private IEventAggregator myEventAggregator;

        private EventCommunicator()
        {
        }

        public static EventCommunicator EventInstance
        {
            get { return LocalEventInstance; }
        }

        public IEventAggregator EventAggregator
        {
            get { return myEventAggregator ?? (myEventAggregator = new EventAggregator()); }
        }
    }
}