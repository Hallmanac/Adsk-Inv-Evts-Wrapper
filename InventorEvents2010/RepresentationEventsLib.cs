using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class RepresentationEventsLib : IRepresentationEventsLib
    {
        private Application inventorApp;

        public RepresentationEventsLib(Application inventorApp)
        {
            this.inventorApp = inventorApp;
            RepresentationEvents = inventorApp.RepresentationEvents;
            Activate();
        }

        #region IRepresentationEventsLib Members

        public RepresentationEventsSink_OnActivateDesignViewRepresentationEventHandler
            OnActivateDesignViewRepDelegate { get; set; }

        public RepresentationEventsSink_OnActivateLevelOfDetailRepresentationEventHandler
            OnActivateLODRepDelegate { get; set; }

        public RepresentationEventsSink_OnActivatePositionalRepresentationEventHandler
            OnActivatePosRepDelegate { get; set; }

        public RepresentationEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }

        public RepresentationEventsSink_OnNewDesignViewRepresentationEventHandler
            OnNewDesignViewRepDelegate { get; set; }

        public RepresentationEventsSink_OnNewLevelOfDetailRepresentationEventHandler
            OnNewLODDelegate { get; set; }

        public RepresentationEventsSink_OnNewPositionalRepresentationEventHandler
            OnNewPosRepDelegate { get; set; }

        public RepresentationEvents RepresentationEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            RepresentationEvents.OnActivateDesignViewRepresentation -=
                OnActivateDesignViewRepDelegate;
            OnActivateDesignViewRepDelegate = null;

            RepresentationEvents.OnActivateLevelOfDetailRepresentation -=
                OnActivateLODRepDelegate;
            OnActivateLODRepDelegate = null;

            RepresentationEvents.OnActivatePositionalRepresentation -= OnActivatePosRepDelegate;
            OnActivatePosRepDelegate = null;

            RepresentationEvents.OnDelete -= OnDeleteDelegate;
            OnDeleteDelegate = null;

            RepresentationEvents.OnNewDesignViewRepresentation -= OnNewDesignViewRepDelegate;
            OnNewDesignViewRepDelegate = null;

            RepresentationEvents.OnNewLevelOfDetailRepresentation -= OnNewLODDelegate;
            OnNewLODDelegate = null;

            RepresentationEvents.OnNewPositionalRepresentation -= OnNewPosRepDelegate;
            OnNewPosRepDelegate = null;
        }

        #endregion

        private void Activate()
        {
            RepresentationEvents.OnActivateDesignViewRepresentation +=
                OnActivateDesignViewRepDelegate;

            RepresentationEvents.OnActivateLevelOfDetailRepresentation +=
                OnActivateLODRepDelegate;

            RepresentationEvents.OnActivatePositionalRepresentation += OnActivatePosRepDelegate;

            RepresentationEvents.OnDelete += OnDeleteDelegate;

            RepresentationEvents.OnNewDesignViewRepresentation += OnNewDesignViewRepDelegate;

            RepresentationEvents.OnNewLevelOfDetailRepresentation += OnNewLODDelegate;

            RepresentationEvents.OnNewPositionalRepresentation += OnNewPosRepDelegate;
        }
    }
}