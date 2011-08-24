using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class BrowserPanesEventsLib : IBrowserPanesEventsLib
    {
        private Application inventorApp;

        public BrowserPanesEventsLib(Application inventorApp, Document document)
        {
            this.inventorApp = inventorApp;
            BrowserPanesEvents = document.BrowserPanes.BrowserPanesEvents;
            Activate();
        }

        #region IBrowserPanesEventsLib Members

        public BrowserPanesSink_OnBrowserNodeActivateEventHandler OnBrowserNodeActivateDelegate { get; set; }

        public BrowserPanesSink_OnBrowserNodeDeleteEntryEventHandler
            OnBrowserNodeDeleteEntryDelegate { get; set; }

        public BrowserPanesSink_OnBrowserNodeGetDisplayObjectsEventHandler
            OnBrowserNodeGetDisplayObjectsDelegate { get; set; }

        public BrowserPanesSink_OnBrowserNodeLabelEditEventHandler OnBrowserNodeLabelEditDelegate { get; set; }

        public BrowserPanesEvents BrowserPanesEvents { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            BrowserPanesEvents.OnBrowserNodeActivate -= OnBrowserNodeActivateDelegate;
            OnBrowserNodeActivateDelegate = null;

            BrowserPanesEvents.OnBrowserNodeDeleteEntry -=
                OnBrowserNodeDeleteEntryDelegate;
            OnBrowserNodeDeleteEntryDelegate = null;

            BrowserPanesEvents.OnBrowserNodeGetDisplayObjects -=
                OnBrowserNodeGetDisplayObjectsDelegate;
            OnBrowserNodeGetDisplayObjectsDelegate = null;

            BrowserPanesEvents.OnBrowserNodeLabelEdit -= OnBrowserNodeLabelEditDelegate;
            OnBrowserNodeLabelEditDelegate = null;
        }

        #endregion

        private void Activate()
        {
            BrowserPanesEvents.OnBrowserNodeActivate += OnBrowserNodeActivateDelegate;

            BrowserPanesEvents.OnBrowserNodeDeleteEntry +=
                OnBrowserNodeDeleteEntryDelegate;

            BrowserPanesEvents.OnBrowserNodeGetDisplayObjects +=
                OnBrowserNodeGetDisplayObjectsDelegate;

            BrowserPanesEvents.OnBrowserNodeLabelEdit += OnBrowserNodeLabelEditDelegate;
        }
    }
}