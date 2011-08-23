using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;
using InventorEvents2011.Interfaces;

namespace InventorEvents2011
{
    public class BrowserPaneEventsLib : IBrowserPaneEventsLib
    {
        private Inventor.Application inventorApp;

        public BrowserPaneSink_OnActivateEventHandler OnActivateDelegate
        { get; set; }
        public BrowserPaneSink_OnDeactivateEventHandler OnDeactivateDelegate
        { get; set; }
        public BrowserPaneSink_OnHelpEventHandler OnHelpDelegate
        { get; set; }

        public BrowserPane BrowserPane { get; private set; }

        public BrowserPaneEventsLib(Inventor.Application inventorApp, BrowserPane browserPane)
        {
            this.inventorApp = inventorApp;
            this.BrowserPane = browserPane;
        }

        /// <summary>
        /// Removes all the delegates from the events and nullifies the delegates
        /// </summary>
        public void Deactivate()
        {
            this.BrowserPane.OnActivate -= this.OnActivateDelegate;
            this.OnActivateDelegate = null;

            this.BrowserPane.OnDeactivate -= this.OnDeactivateDelegate;
            this.OnDeactivateDelegate = null;

            this.BrowserPane.OnHelp -= this.OnHelpDelegate;
            this.OnHelpDelegate = null;
        }
    }
}
