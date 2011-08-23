using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IBrowserPaneEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.BrowserPane object
        /// </summary>
        BrowserPane BrowserPane { get; }

        #region Event Handler Delegates
        BrowserPaneSink_OnActivateEventHandler OnActivateDelegate { get; set; }
        BrowserPaneSink_OnDeactivateEventHandler OnDeactivateDelegate { get; set; }
        BrowserPaneSink_OnHelpEventHandler OnHelpDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
