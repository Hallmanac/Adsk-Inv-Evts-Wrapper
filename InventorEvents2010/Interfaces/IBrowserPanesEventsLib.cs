using System;
using Inventor;

namespace InventorEvents2010.Interfaces
{
    public interface IBrowserPanesEventsLib
    {
        /// <summary>
        /// Property representing the Inventor.BrowserPanesEvents object
        /// </summary>
        BrowserPanesEvents BrowserPanesEvents { get; }

        #region Event Handler Delegates
        BrowserPanesSink_OnBrowserNodeActivateEventHandler 
            OnBrowserNodeActivateDelegate { get; set; }
        BrowserPanesSink_OnBrowserNodeDeleteEntryEventHandler 
            OnBrowserNodeDeleteEntryDelegate { get; set; }
        BrowserPanesSink_OnBrowserNodeGetDisplayObjectsEventHandler 
            OnBrowserNodeGetDisplayObjectsDelegate { get; set; }
        BrowserPanesSink_OnBrowserNodeLabelEditEventHandler 
            OnBrowserNodeLabelEditDelegate { get; set; }
        #endregion

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        void Deactivate();
    }
}
