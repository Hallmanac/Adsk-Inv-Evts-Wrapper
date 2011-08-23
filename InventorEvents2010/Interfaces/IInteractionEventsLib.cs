using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IInteractionEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.InteractionEvents object.  If it's not specifically
        /// set, then it will auto-set itself (upon a Get call) using the Inventor.Application 
        /// object that was passed into the constructor.
        /// </summary>
        InteractionEvents InteractionEvents { get; set; }

        #region
        InteractionEventsSink_OnActivateEventHandler OnActivateDelegate { get; set; }
        InteractionEventsSink_OnHelpEventHandler OnHelpDelegate { get; set; }
        InteractionEventsSink_OnResumeEventHandler OnResumeDelegate { get; set; }
        InteractionEventsSink_OnSuspendEventHandler OnSuspendDelegate { get; set; }
        InteractionEventsSink_OnTerminateEventHandler OnTerminateDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
