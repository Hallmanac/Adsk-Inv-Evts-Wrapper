using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IMouseEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.InteractionEvents object used to initialize the
        /// MouseEvents property
        /// </summary>
        InteractionEvents LocalInteractionEvents { get; set; }

        /// <summary>
        /// Property representing the Inventor.MouseEvents object
        /// </summary>
        MouseEvents MouseEvents { get; }

        #region Event Handler Delegates
        MouseEventsSink_OnMouseClickEventHandler OnMouseClickDelegate { get; set; }
        MouseEventsSink_OnMouseDoubleClickEventHandler OnMouseDoubleClickDelegate { get; set; }
        MouseEventsSink_OnMouseDownEventHandler OnMouseDownDelegate { get; set; }
        MouseEventsSink_OnMouseLeaveEventHandler OnMouseLeaveDelegate { get; set; }
        MouseEventsSink_OnMouseMoveEventHandler OnMouseMoveDelegate { get; set; }
        MouseEventsSink_OnMouseUpEventHandler OnMouseUpDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
