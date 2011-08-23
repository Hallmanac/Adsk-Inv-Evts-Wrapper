using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface ITriadEventsLib
    {
        /// <summary>
        /// Property that is leveraged in auto-setting the TriadEvents property
        /// </summary>
        InteractionEvents LocalInteractionEvents { get; set; }

        /// <summary>
        /// Property representing the Inventor.TriadEvents object.
        /// </summary>
        TriadEvents TriadEvents { get; }

        TriadEventsSink_OnActivateEventHandler OnActivateDelegate { get; set; }
        TriadEventsSink_OnEndMoveEventHandler OnEndMoveDelegate { get; set; }
        TriadEventsSink_OnEndSequenceEventHandler OnEndSequenceDelegate { get; set; }
        TriadEventsSink_OnMoveEventHandler OnMoveDelegate { get; set; }
        TriadEventsSink_OnMoveTriadOnlyToggleEventHandler OnMoveTriadOnlyToggleDelegate { get; set; }
        TriadEventsSink_OnSegmentSelectionChangeEventHandler OnSegmentSelectionChangeDelegate { get; set; }
        TriadEventsSink_OnStartMoveEventHandler OnStartMoveDelegate { get; set; }
        TriadEventsSink_OnStartSequenceEventHandler OnStartSequenceDelegate { get; set; }
        TriadEventsSink_OnTerminateEventHandler OnTerminateDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
