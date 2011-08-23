using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IUserInputEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.UserInputEvents object
        /// </summary>
        UserInputEvents UserInputEvents { get; }
        
        UserInputEventsSink_OnActivateCommandEventHandler OnActivateCommandDelegate { get; set; }
        UserInputEventsSink_OnContextMenuEventHandler OnContextMenuDelegate { get; set; }
        UserInputEventsSink_OnDoubleClickEventHandler OnDoubleClickDelegate { get; set; }
        UserInputEventsSink_OnDragEventHandler OnDragDelegate { get; set; }
        UserInputEventsSink_OnPreSelectEventHandler OnPreSelectDelegate { get; set; }
        UserInputEventsSink_OnSelectEventHandler OnSelectDelegate { get; set; }
        UserInputEventsSink_OnStartCommandEventHandler OnStartCommandDelegate { get; set; }
        UserInputEventsSink_OnStopCommandEventHandler OnStopCommandDelegate { get; set; }
        UserInputEventsSink_OnStopPreSelectEventHandler OnStopPreSelectDelegate { get; set; }
        UserInputEventsSink_OnTerminateCommandEventHandler OnTerminateCommandDelegate { get; set; }
        UserInputEventsSink_OnUnSelectEventHandler OnUnSelectDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
