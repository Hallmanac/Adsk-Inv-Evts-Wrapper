using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class RepresentationEventsLib : IRepresentationEventsLib
    {
        private Inventor.Application inventorApp;

        public RepresentationEventsSink_OnActivateDesignViewRepresentationEventHandler
            OnActivateDesignViewRepDelegate { get; set; }
        public RepresentationEventsSink_OnActivateLevelOfDetailRepresentationEventHandler
            OnActivateLODRepDelegate { get; set; }
        public RepresentationEventsSink_OnActivatePositionalRepresentationEventHandler
            OnActivatePosRepDelegate { get; set; }
        public RepresentationEventsSink_OnDeleteEventHandler OnDeleteDelegate
        { get; set; }
        public RepresentationEventsSink_OnNewDesignViewRepresentationEventHandler
            OnNewDesignViewRepDelegate { get; set; }
        public RepresentationEventsSink_OnNewLevelOfDetailRepresentationEventHandler
            OnNewLODDelegate { get; set; }
        public RepresentationEventsSink_OnNewPositionalRepresentationEventHandler
            OnNewPosRepDelegate { get; set; }

        public RepresentationEvents RepresentationEvents { get; private set; }

        public RepresentationEventsLib(Inventor.Application inventorApp)
        {
            this.inventorApp = inventorApp;
            this.RepresentationEvents = inventorApp.RepresentationEvents;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.RepresentationEvents.OnActivateDesignViewRepresentation -=
                this.OnActivateDesignViewRepDelegate;
            this.OnActivateDesignViewRepDelegate = null;

            this.RepresentationEvents.OnActivateLevelOfDetailRepresentation -=
                this.OnActivateLODRepDelegate;
            this.OnActivateLODRepDelegate = null;

            this.RepresentationEvents.OnActivatePositionalRepresentation -= this.OnActivatePosRepDelegate;
            this.OnActivatePosRepDelegate = null;

            this.RepresentationEvents.OnDelete -= this.OnDeleteDelegate;
            this.OnDeleteDelegate = null;

            this.RepresentationEvents.OnNewDesignViewRepresentation -= this.OnNewDesignViewRepDelegate;
            this.OnNewDesignViewRepDelegate = null;

            this.RepresentationEvents.OnNewLevelOfDetailRepresentation -= this.OnNewLODDelegate;
            this.OnNewLODDelegate = null;

            this.RepresentationEvents.OnNewPositionalRepresentation -= this.OnNewPosRepDelegate;
            this.OnNewPosRepDelegate = null;
        }
    }
}
