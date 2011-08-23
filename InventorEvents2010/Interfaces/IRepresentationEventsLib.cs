using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IRepresentationEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.RepresentationEvents object
        /// </summary>
        RepresentationEvents RepresentationEvents { get; }
        
        RepresentationEventsSink_OnActivateDesignViewRepresentationEventHandler 
            OnActivateDesignViewRepDelegate { get; set; }
        RepresentationEventsSink_OnActivateLevelOfDetailRepresentationEventHandler 
            OnActivateLODRepDelegate { get; set; }
        RepresentationEventsSink_OnActivatePositionalRepresentationEventHandler 
            OnActivatePosRepDelegate { get; set; }
        RepresentationEventsSink_OnDeleteEventHandler OnDeleteDelegate { get; set; }
        RepresentationEventsSink_OnNewDesignViewRepresentationEventHandler 
            OnNewDesignViewRepDelegate { get; set; }
        RepresentationEventsSink_OnNewLevelOfDetailRepresentationEventHandler 
            OnNewLODDelegate { get; set; }
        RepresentationEventsSink_OnNewPositionalRepresentationEventHandler 
            OnNewPosRepDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
