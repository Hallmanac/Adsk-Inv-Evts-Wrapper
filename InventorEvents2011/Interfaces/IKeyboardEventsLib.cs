using System;
using Inventor;

namespace InventorEvents2011.Interfaces
{
    public interface IKeyboardEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.KeyboardEvents object.  It needs the 
        /// Inventor.InteractionEvents object to be initialized so it uses the 
        /// "LocalInteractionEvents" property to do that inside its Getter.
        /// </summary>
        KeyboardEvents KeyboardEvents { get; }

        /// <summary>
        /// Property representing the Inventor.InteractionEvents object which is used to initilize
        /// the KeyboardEvents property
        /// </summary>
        InteractionEvents LocalInteractionEvents { get; set; }

        #region
        KeyboardEventsSink_OnKeyDownEventHandler OnKeyDownDelegate { get; set; }
        KeyboardEventsSink_OnKeyPressEventHandler OnKeyPressDelegate { get; set; }
        KeyboardEventsSink_OnKeyUpEventHandler OnKeyUpDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
