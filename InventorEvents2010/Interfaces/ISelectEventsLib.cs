using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface ISelectEventsLib
    {
        /// <summary>
        /// Property used to access the Inventor.SelectEvents object via the "SelectEvents" property
        /// </summary>
        InteractionEvents LocalInteractionEvents { get; set; }

        /// <summary>
        /// Property representing the Inventor.SelectEvents object. Auto-initialized via the 
        /// LocalInteractionEvents property
        /// </summary>
        SelectEvents SelectEvents { get; }

        SelectEventsSink_OnPreSelectEventHandler OnPreSelectDelegate { get; set; }
        SelectEventsSink_OnPreSelectMouseMoveEventHandler OnPreSelectMouseMoveDelegate { get; set; }
        SelectEventsSink_OnSelectEventHandler OnSelectDelegate { get; set; }
        SelectEventsSink_OnStopPreSelectEventHandler OnStopPreSelectDelegate { get; set; }
        SelectEventsSink_OnUnSelectEventHandler OnUnSelectDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
