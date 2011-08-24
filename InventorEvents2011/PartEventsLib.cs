using Inventor;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class PartEventsLib : IPartEventsLib
    {
        private Application inventorApp;
        private PartComponentDefinition partComponentDefinition;

        public PartEventsLib(Application inventorApp, PartComponentDefinition
                                                          partComponentDef)
        {
            this.inventorApp = inventorApp;
            PartEvents = partComponentDef.PartEvents;
            Activate();
        }

        #region IPartEventsLib Members

        public PartEventsSink_OnSurfaceBodyChangedEventHandler OnSurfaceBodyChangedDelegate { get; set; }

        public PartEvents PartEvents { get; private set; }

        public PartComponentDefinition PartComponentDefinition
        {
            get { return partComponentDefinition; }
            set
            {
                partComponentDefinition = value;
                PartEvents = value.PartEvents;
            }
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            PartEvents.OnSurfaceBodyChanged -= OnSurfaceBodyChangedDelegate;
            OnSurfaceBodyChangedDelegate = null;
        }

        #endregion

        private void Activate()
        {
            PartEvents.OnSurfaceBodyChanged += OnSurfaceBodyChangedDelegate;
        }
    }
}