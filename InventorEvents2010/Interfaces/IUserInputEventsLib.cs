using System;
using Inventor;

namespace InventorEvents2010.Interfaces
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
        UserInputEventsSink_OnStartCommandEventHandler OnStartCommandDelegate { get; set; }
        UserInputEventsSink_OnStopCommandEventHandler OnStopCommandDelegate { get; set; }
        UserInputEventsSink_OnTerminateCommandEventHandler OnTerminateCommandDelegate { get; set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
