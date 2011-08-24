using Inventor;
using InventorEvents2010.Interfaces;

namespace InventorEvents2010
{
    public class BrowserPaneEventsLib : IBrowserPaneEventsLib
    {
        private Application inventorApp;

        public BrowserPaneEventsLib(Application inventorApp, BrowserPane browserPane)
        {
            this.inventorApp = inventorApp;
            BrowserPane = browserPane;
            Activate();
        }

        #region IBrowserPaneEventsLib Members

        public BrowserPaneSink_OnActivateEventHandler OnActivateDelegate { get; set; }
        public BrowserPaneSink_OnDeactivateEventHandler OnDeactivateDelegate { get; set; }
        public BrowserPaneSink_OnHelpEventHandler OnHelpDelegate { get; set; }

        public BrowserPane BrowserPane { get; private set; }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            BrowserPane.OnActivate -= OnActivateDelegate;
            OnActivateDelegate = null;

            BrowserPane.OnDeactivate -= OnDeactivateDelegate;
            OnDeactivateDelegate = null;

            BrowserPane.OnHelp -= OnHelpDelegate;
            OnHelpDelegate = null;
        }

        #endregion

        private void Activate()
        {
            BrowserPane.OnActivate += OnActivateDelegate;

            BrowserPane.OnDeactivate += OnDeactivateDelegate;

            BrowserPane.OnHelp += OnHelpDelegate;
        }
    }
}